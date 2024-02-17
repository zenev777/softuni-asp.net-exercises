using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SoftUniBazar.Data.Models.DataConstants;

namespace SoftUniBazar.Data.Models
{
    public class Ad
    {
        //Has Id – a unique integer, Primary Key
        [Key]
        public int Id { get; set; }
        
        //Has Name – a string with min length 5 and max length 25 (required)
        [Required]
        [MaxLength(AdNameMaxLenght)]
        public string Name { get; set; } = string.Empty;
        
        //Has Description – a string with min length 15 and max length 250 (required)        
        [Required]
        [MaxLength(AdDescriptionMaxLenght)]
        public string Description { get; set; } = string.Empty;

        //Has Price – a decimal (required)        
        [Required]
        public decimal Price { get; set; }

        //Has OwnerId – a string (required)
        [Required]
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey(nameof(OwnerId))]
        //Has Owner – an IdentityUser(required)
        [Required]
        public IdentityUser Owner { get; set; } = null!;

        //Has ImageUrl – a string (required)
        [Required]
        public string ImageUrl { get; set; }

        //Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended,
        //if you are having troubles with this one, you are free to use another one)
        [Required]
        public DateTime CreatedOn { get; set; }

        //Has CategoryId – an integer, foreign key (required)
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        //Has Category – a Category(required)
        public Category Category { get; set; }
    }
}
