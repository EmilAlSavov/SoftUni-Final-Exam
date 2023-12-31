﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HiparAppData.Data.Models;
using Microsoft.AspNetCore.Identity;
using RastafarAppData.Data.Models;

namespace RastafarWebApp.Data.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string Name { get; set; } = null!;

        [StringLength(2000, MinimumLength = 20)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImgsUrl { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Destination { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CampTypeId))]
        public CampType CampType { get; set; }

        [Required]
        public Guid CampTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TravelTypeId))]
        public TravelType TravelType { get; set; }

        [Required]
        public Guid TravelTypeId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;

        [Required]
        public ApplicationUser Owner { get; set; }

        [ForeignKey(nameof(CampId))]
        public Camp? Camp { get; set; }

        public Guid? CampId { get; set; }

        public List<IdentityUserPosts> Participants { get; set; } = new List<IdentityUserPosts>();
    }
}
