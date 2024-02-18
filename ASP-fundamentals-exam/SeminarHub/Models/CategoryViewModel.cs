using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
