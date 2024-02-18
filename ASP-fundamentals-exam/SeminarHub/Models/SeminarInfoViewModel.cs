using System.ComponentModel.DataAnnotations;

namespace SeminarHub.Models
{
    public class SeminarInfoViewModel
    {
        public int Id { get; set; }

        public string Topic { get; set; } = string.Empty;

        public string Lecturer { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Organizer { get; set; } = null!;

        public string DateAndTime { get; set; } = string.Empty;
    }
}
