using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SeminarHub.Data.DataConstants;

namespace SeminarHub.Data.Models
{
    public class Seminar
    {
        [Key]
        [Comment("Seminar identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(SeminarTopicMaxlength)]
        [Comment("Seminar topic")]
        public string Topic { get; set; } = string.Empty;

        [Required]
        [MaxLength(SeminarLecturerMaxlength)]
        [Comment("Seminar lecturer")]
        public string Lecturer { get; set; } = string.Empty;

        [Required]
        [MaxLength(SeminarDetailsMaxlength)]
        [Comment("Seminar details")]
        public string Details { get; set; } = string.Empty;

        [Required]
        [Comment("Organizer identifier")]
        public string OrganizerId { get; set; } = string.Empty;

        [ForeignKey(nameof(OrganizerId))]

        [Required]
        [Comment("Identity user")]
        public IdentityUser Organizer { get; set; } = null!;

        [Required]
        [Comment("Date and time of the seminar")]
        public DateTime DateAndTime { get; set; }

        [Range(SeminarDurationMinlength,SeminarDurationMaxlength)]
        [Comment("Seminar duration")]
        public int Duration { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]

        public Category Category { get; set; } = null!;

        [Comment("Seminar list")]
        public ICollection<SeminarParticipant> SeminarsParticipants { get; set; } = new List<SeminarParticipant>();
    }
}
