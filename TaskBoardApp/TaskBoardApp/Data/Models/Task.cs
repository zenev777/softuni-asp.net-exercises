using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TaskBoardApp.Data.DataConstants;
namespace TaskBoardApp.Data.Models
{
    [Comment("Task table")]
    public class Task
    {
        //· Id – a unique integer, Primary Key
        [Key]
        [Comment("Task identifier")]
        public int Id { get; set; }

        //· Title – a string with min length 5 and max length 70 (required)
        [Required]
        [MaxLength(TaskTitleMinLenght)]
        [Comment("Task title")]
        public string Title { get; set; }

        //· Description – a string with min length 10 and max length 1000 (required)
        [Required]
        [MaxLength(TaskDescriptionMaxLenght)]
        [Comment("Task description")]
        public string Description { get; set; }

        //· CreatedOn – date and time
        [Comment("Date of creation")]
        public DateTime CreatedOn { get; set; }

        //· BoardId – an integer
        [Comment("Board identifier")]
        public int BoardId { get; set; }

        //· OwnerId – an integer(required)
        [Required]
        [Comment("Application user identifier")]
        public string OwnerId { get; set; } = string.Empty;

        //· Board – a Board object
        [ForeignKey(nameof(BoardId))]
        public Board? Board { get; set; }

        //· Owner – an IdentityUser object
        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; }
    }
}
