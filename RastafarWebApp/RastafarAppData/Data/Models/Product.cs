using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppData.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 30)]
        public string Description { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
