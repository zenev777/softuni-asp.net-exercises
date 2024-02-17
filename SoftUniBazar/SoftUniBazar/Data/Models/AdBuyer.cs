using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUniBazar.Data.Models
{
    public class AdBuyer
    {
        //BuyerId – a string, Primary Key, foreign key(required)
        //Buyer – IdentityUser
        [Required]
        public string BuyerId { get; set; }

        [ForeignKey(nameof(BuyerId))]

        public IdentityUser Buyer { get; set; } = null!;

        //AdId – an integer, Primary Key, foreign key(required)
        //Ad – Ad
        [Required]
        public int AdId { get; set; }

        [ForeignKey(nameof(AdId))]

        public Ad Ad { get; set; } = null!;
    }
}
