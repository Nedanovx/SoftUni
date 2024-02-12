using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.TaskConstants;

namespace TaskBoardApp.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxDescriptionLength, MinimumLength = MinDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Owner { get; set; } = string.Empty;
    }
}
