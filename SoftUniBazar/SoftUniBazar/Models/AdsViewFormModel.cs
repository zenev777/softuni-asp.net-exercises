using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Data.Models.DataConstants;

namespace SoftUniBazar.Models
{
    public class AdsViewFormModel
    {
        [Required]
        [StringLength(AdNameMaxLenght, MinimumLength = AdNameMinLenght,
            ErrorMessage = "Ad name must be between 5 and 25 characters.")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(AdDescriptionMaxLenght, MinimumLength = AdDescriptionMinLenght,
            ErrorMessage = "Description must be between 15 and 250 characters.")]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}
