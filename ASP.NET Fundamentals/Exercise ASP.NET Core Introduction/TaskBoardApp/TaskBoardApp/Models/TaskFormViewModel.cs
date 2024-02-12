using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.TaskConstants;


namespace TaskBoardApp.Models
{
    public class TaskFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredError)]
        [StringLength(MaxTitleLength, 
            MinimumLength = MinTitleLength,
            ErrorMessage = ErrorMessages.StringLengthError)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequiredError)]
        [StringLength(MaxDescriptionLength, 
            MinimumLength = MinDescriptionLength,
            ErrorMessage = ErrorMessages.StringLengthError)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequiredError)]
        public int? BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; } = new List<TaskBoardModel>();
    }
}
