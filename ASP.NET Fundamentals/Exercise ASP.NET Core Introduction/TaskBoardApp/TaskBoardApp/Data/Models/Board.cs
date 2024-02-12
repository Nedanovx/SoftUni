using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.BoardConstants;

namespace TaskBoardApp.Data.Models
{
    public class Board
    {
        [Key]
        [Comment("Board indetifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxBoardNameLength)]
        [Comment("Board name")]
        public string Name { get; set; } =string.Empty;

        public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
    }
}