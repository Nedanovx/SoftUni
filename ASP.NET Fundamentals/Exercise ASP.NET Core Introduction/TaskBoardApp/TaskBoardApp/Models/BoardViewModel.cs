using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.BoardConstants;

namespace TaskBoardApp.Models
{
    public class BoardViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxBoardNameLength, MinimumLength = MinBoardNameLength)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>(); 
    }
}
