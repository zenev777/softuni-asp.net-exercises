using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Homies.Data.DataConstants;


namespace Homies.Data
{
    public class Event
    {
        //· Has Id – a unique integer, Primary Key
        [Key]
        public int Id { get; set; }

        //· Has Name – a string with min length 5 and max length 20 (required)
        [Required]
        [MaxLength(EventNameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        //· Has Description – a string with min length 15 and max length 150 (required)
        [Required]
        [MaxLength(EventDescriptionMaxLenght)]
        public string Description { get; set; } = string.Empty;

        //· Has OrganiserId – an string (required)
        [Required]
        public string OrganiserId { get; set; } = string.Empty;

        //· Has Organiser – an IdentityUser(required)
        [Required]
        [ForeignKey(nameof(OrganiserId))]
        public IdentityUser Organiser { get; set; } = null!;

        //· Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended,
        //if you are having troubles with this one, you are free to use another one)
        [Required]
        public DateTime CreatedOn { get; set; }

        //· Has Start – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended,
        //if you are having troubles with this one, you are free to use another one)
        [Required]
        public DateTime Start { get; set; }

        //· Has End – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended,
        //if you are having troubles with this one, you are free to use another one)
        [Required]
        public DateTime End { get; set; }

        //· Has TypeId – an integer, foreign key (required)
        [Required]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]

        //· Has Type – a Type(required)
        [Required]
        public Type Type { get; set; }

        //· Has EventsParticipants – a collection of type EventParticipant
        public IList<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
    }
}
