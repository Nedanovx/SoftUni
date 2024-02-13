using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskBoardAppDbContext data;

        public HomeController(TaskBoardAppDbContext context)
        {
            data = context;
        }

        public async Task<IActionResult> Index()
        {
            var taskBoards = await data.Boards
                 .Select(b => b.Name)
                 .Distinct().ToListAsync();

            var tasksCounts = new List<HomeBoardModel>();

            foreach (var boardName in taskBoards)
            {
                var tasksInBoard = data.Tasks.Where(t => t.Board.Name == boardName).Count();

                tasksCounts.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = tasksInBoard
                });
            }

            var userTasksCount = -1;

            if (User.Identity.IsAuthenticated)
            {
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                userTasksCount = data.Tasks.Where(t => t.OwnerId == currentUserId).Count();
            }

            var homeModel = new HomeViewModel()
            {
                AllTasksCount = data.Tasks.Count(),
                BoardsWithTasksCount = tasksCounts,
                UserTasksCount = userTasksCount
            };

            return View(homeModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
