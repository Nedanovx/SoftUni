using Homies.Data;
using Homies.Data.Constants;
using Homies.Data.Models;
using Homies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Claims;

namespace Homies.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        private readonly HomiesDbContext data;

        public EventController(HomiesDbContext context)
        {
            data = context;
        }
        public async Task<IActionResult> All()
        {
            var events = await data.Events
                .AsNoTracking()
                .Select(e => new EventInfoViewModel(
                    e.Id,
                    e.Name,
                    e.Start,
                    e.Type.Name,
                    e.Organiser.UserName
                )).ToListAsync();

            return View(events);
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            var events = await data.Events
                .Where(e => e.Id == id)
                .Include(e => e.EvenstParticipants)
                .FirstOrDefaultAsync();

            if(events == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();
            if(!events.EvenstParticipants.Any(e => e.HelperId == userId))
            {
                events.EvenstParticipants.Add(new EventParticipant()
                {
                    EventId = events.Id,
                    HelperId = userId
                });

                await data.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Joined));
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            string userId = GetUserId();

            var model = await data.EventParticipants
                .Where(ep => ep.HelperId == userId)
                .AsNoTracking()
                .Select(ep => new EventInfoViewModel(
                    ep.EventId,
                    ep.Event.Name,
                    ep.Event.Start,
                    ep.Event.Type.Name,
                    ep.Event.Organiser.UserName
                )).ToListAsync();
            return View(model);

        }

        public async Task<IActionResult> Leave(int id)
        {
            var events = await data.Events
                .Where(e => e.Id == id)
                .Include(e => e.EvenstParticipants)
                .FirstOrDefaultAsync();

            if (events == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            var ep = events.EvenstParticipants.FirstOrDefault(ep => ep.HelperId == userId);

            if (ep == null)
            {
                return BadRequest();
            }

            events.EvenstParticipants.Remove(ep);

            await data.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EventFormViewModel();
            model.Types = await GetTypes();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventFormViewModel model)
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            if(!DateTime.TryParseExact(model.Start, 
                Validation.DateFormat, 
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out start))
            {
                ModelState.AddModelError(nameof(model.Start), $"Invalid date! Format must be: {Validation.DateFormat}");
            }

            if (!DateTime.TryParseExact(model.End,
               Validation.DateFormat,
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out end))
            {
                ModelState.AddModelError(nameof(model.End), $"Invalid date! Format must be: {Validation.DateFormat}");
            }

            if(!ModelState.IsValid)
            {
                model.Types = await GetTypes();
                return View(model);
            }

            var entity = new Event()
            {
                CreatedOn = DateTime.Now,
                Description = model.Description,
                Name = model.Name,
                OrganiserId = GetUserId(),
                TypeId = model.TypeId,
                Start = start,
                End = end
            };

            await data.Events.AddAsync(entity);
            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var currentEvent = await data.Events.FindAsync(id);

            if(currentEvent == null)
            {
                return BadRequest();
            }

            if(currentEvent.OrganiserId != GetUserId())
            {
                return Unauthorized();
            }

            var model = new EventFormViewModel()
            {
                Description = currentEvent.Description,
                Name = currentEvent.Name,
                End = currentEvent.End.ToString(Validation.DateFormat),
                Start = currentEvent.Start.ToString(Validation.DateFormat),
                TypeId = currentEvent.TypeId,
            };

            model.Types = await GetTypes();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EventFormViewModel model, int id)
        {
            var currentEvent = await data.Events.FindAsync(id);

            if (currentEvent == null)
            {
                return BadRequest();
            }

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            if (currentEvent.OrganiserId != GetUserId())
            {
                return Unauthorized();
            }
            if (!DateTime.TryParseExact(model.Start,
                Validation.DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out start))
            {
                ModelState.AddModelError(nameof(model.Start), $"Invalid date! Format must be: {Validation.DateFormat}");
            }

            if (!DateTime.TryParseExact(model.End,
               Validation.DateFormat,
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out end))
            {
                ModelState.AddModelError(nameof(model.End), $"Invalid date! Format must be: {Validation.DateFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Types = await GetTypes();
                return View(model);
            }
            currentEvent.Start = start;
            currentEvent.End = end;
            currentEvent.Description = model.Description;
            currentEvent.Name = model.Name;
            currentEvent.TypeId = model.TypeId;

            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await data.Events
                .Where(e => e.Id == id)
                .AsNoTracking()
                .Select(e => new EventDetailsViewModel()
                {
                    Name = e.Name,
                    Description = e.Description,
                    CreatedOn = e.CreatedOn.ToString(Validation.DateFormat),
                    Start = e.Start.ToString(Validation.DateFormat),
                    End = e.End.ToString(Validation.DateFormat),
                    Organiser = e.Organiser.UserName,
                    Type = e.Type.Name
                })
                .FirstOrDefaultAsync();

            if(model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }

        private async Task<IEnumerable<TypeViewModel>> GetTypes()
        {
            return await data.Types
                .AsNoTracking()
                .Select(t => new TypeViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                }).ToListAsync();
        }
    }
}
