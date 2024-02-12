using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TaskBoardApp.Data.DataConstants.TaskConstants;

namespace TaskBoardApp.Data.Models
{
    [Comment("Board Task")]
    public class Task
    {
        [Key]
        [Comment("Task identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        [Comment("Task title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(MaxDescriptionLength)]
        [Comment("Task Description")]
        public string Description { get; set; } = string.Empty;

        [Comment("Date of creation")]
        public DateTime? CreatedOn { get; set; }

        [Comment("Board identifier")]
        public int? BoardId { get; set; }

        [Required]
        [Comment("Application user identifier")]
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey(nameof(BoardId))]
        public Board? Board { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; } = null!;
    }
}
