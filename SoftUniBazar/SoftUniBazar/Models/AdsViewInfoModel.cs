using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Data.Models.DataConstants;

namespace SoftUniBazar.Models
{
    public class AdsViewInfoModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(AdNameMaxLenght, MinimumLength = AdNameMinLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(AdDescriptionMaxLenght, MinimumLength = AdNameMinLenght)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public string CreatedOn { get; set; }

        [Required]
        public string Category { get; set; }

        public string Owner { get; set; }

    }
}
