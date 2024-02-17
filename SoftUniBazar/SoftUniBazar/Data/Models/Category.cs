using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Data.Models.DataConstants;

namespace SoftUniBazar.Data.Models
{
    public class Category
    {
        //Has Id – a unique integer, Primary Key
        [Key]
        public int Id { get; set; }

        //Has Name – a string with min length 3 and max length 15 (required)
        [Required]
        [MaxLength(CategoryNameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        //Has Ads – a collection of type Ad
        public IList<Ad> Ads { get; set; } = new List<Ad>();
    }
}