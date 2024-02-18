using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Models
{
    public class SeminarFormViewModel
    {

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(SeminarTopicMaxlength,MinimumLength = SeminarTopicMinlength, ErrorMessage = StringLengthErrorMessage)]
        public string Topic { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(SeminarLecturerMaxlength, MinimumLength =SeminarLecturerMinlength, ErrorMessage = StringLengthErrorMessage)]
        public string Lecturer { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(SeminarDetailsMaxlength,MinimumLength = SeminarDetailsMinlength, ErrorMessage = StringLengthErrorMessage)]
        public string Details { get; set; } = string.Empty;


        [Required(ErrorMessage = RequireErrorMessage)]
        public string DateAndTime { get; set; } = string.Empty;

        [Range(SeminarDurationMinlength, SeminarDurationMaxlength,ErrorMessage = RangeIntErrorMessage)]
        public int Duration { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        public int CategoryId { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();

    }
}
