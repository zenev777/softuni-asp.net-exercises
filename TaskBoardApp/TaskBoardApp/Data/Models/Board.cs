using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Data.Models
{
    [Comment("Board table")]
    public class Board
    {
        //· Id – a unique integer, Primary Key
        [Key]
        [Comment("Board identifier")]
        public int Id { get; set; }

        //· Name – a string with min length 3 and max length 30 (required)
        [Required]
        [MaxLength(BoardNameMaxLength)]
        public string Name { get; set; }

        //· Tasks – a collection of Task
        public IEnumerable<Task> Tasks { get; set; } = Enumerable.Empty<Task>();

    }
}