﻿using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppData.Data.Models
{
    public class Camp
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public Guid CountryId { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
