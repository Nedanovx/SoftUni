using System.ComponentModel.DataAnnotations;
using static Homies.Data.Constants.Validation;
using static Homies.Data.Constants.ErrorConst;

namespace Homies.Models
{
    public class EventFormViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(EventNameMaxLength, 
            MinimumLength = EventNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(MaxEventDescriptionLength,
            MinimumLength = MinEventDescriptionLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string Start { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string End { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int TypeId { get; set; }

        public IEnumerable<TypeViewModel> Types { get; set; } = new List<TypeViewModel>(); 
    }
}
