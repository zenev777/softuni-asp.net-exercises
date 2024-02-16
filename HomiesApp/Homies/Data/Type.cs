using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants;

namespace Homies.Data
{
    public class Type
    {
        //· Has Id – a unique integer, Primary Key
        [Key]
        public int Id { get; set; }

        //· Has Name – a string with min length 5 and max length 15 (required)
        [Required]
        [MaxLength(TypeNameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        //· Has Events – a collection of type Event
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
    }
}
