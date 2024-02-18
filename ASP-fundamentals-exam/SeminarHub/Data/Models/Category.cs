using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxlength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("Category list")]
        public ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
    }
}