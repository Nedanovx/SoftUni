using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Homies.Data.Constants.Validation;
using Type = Homies.Data.Models.Type;

namespace Homies.Data.Models
{
    public class Event
    {
        [Key]
        [Comment("Event identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(EventNameMaxLength)]
        [Comment("Event name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(MaxEventDescriptionLength)]
        [Comment("Event Description")]
        public string Description { get; set; }= string.Empty;

        [Required]
        [Comment("Organiser identifier")]
        public string OrganiserId = string.Empty;

        [Required]
        [ForeignKey(nameof(OrganiserId))]
        public IdentityUser Organiser { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime Start { get; set;}

        public DateTime End { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        public IList<EventParticipant> EvenstParticipants { get; set; } = new List<EventParticipant>();
    }
}
