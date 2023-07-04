﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public List<string> ImgsUrl { get; set; } = new List<string>();

        [Required]
        public string Destination { get; set; } = null!;

        [Required]
        public CampType campType { get; set; }

        [Required]
        public TravelType travelType { get; set; }
    }
}
