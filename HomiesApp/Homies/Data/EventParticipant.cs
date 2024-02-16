using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data
{
    public class EventParticipant
    {
        //· HelperId – a string, Primary Key, foreign key(required)
        [Required]
        public string HelperId { get; set; } = string.Empty;

        [ForeignKey(nameof(HelperId))]

        //· Helper – IdentityUser
        public IdentityUser Helper { get; set; } = null!;

        //· EventId – an integer, Primary Key, foreign key(required)
        [Required]
        public int EventId { get; set; }

        [ForeignKey(nameof(EventId))]

        //· Event – Event
        public Event Event { get; set; } = null!;
    }
}