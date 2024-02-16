using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants;

namespace Homies.Models
{
    public class EventFormViewModel
    {
        [Required(ErrorMessage = RequireErrorMasage)]
        [StringLength(EventNameMaxLenght, MinimumLength = EventDescriptionMinLenght, ErrorMessage = StringLenghtErrorMassage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMasage)]
        [StringLength(EventDescriptionMaxLenght, MinimumLength = EventDescriptionMinLenght, ErrorMessage = StringLenghtErrorMassage)]
        public string Description { get; set; } = string.Empty;


        [Required(ErrorMessage = RequireErrorMasage)]
        public string Start { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMasage)]
        public string End { get; set; } = string.Empty;


        [Required(ErrorMessage = RequireErrorMasage)]
        public int TypeId { get; set; }

        public IEnumerable<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();
    }
}
