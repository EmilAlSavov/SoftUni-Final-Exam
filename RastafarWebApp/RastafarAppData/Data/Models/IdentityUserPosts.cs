using HiparAppData.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RastafarWebApp.Data.Models
{
    public class IdentityUserPosts
    {
        [Required]
        [ForeignKey(nameof(Post))]
        public Guid PostId { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        [ForeignKey(nameof(Participant))]
        public string ParticipantId { get; set; }

        [Required]
        public ApplicationUser Participant { get; set; }
    }
}