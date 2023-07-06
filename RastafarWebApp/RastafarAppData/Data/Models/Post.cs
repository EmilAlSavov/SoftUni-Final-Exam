
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using RastafarWebApp.Data.Models.Enums;

namespace RastafarWebApp.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string Name { get; set; } = null!;

        [StringLength(2000, MinimumLength = 50)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImgsUrl { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Destination { get; set; } = null!;

        [Required]
        public CampType campType { get; set; }

        [Required]
        public TravelType travelType { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;

        [Required]
        public IdentityUser Owner { get; set; }

        public List<IdentityUserPosts> Participants { get; set; }
    }
}
