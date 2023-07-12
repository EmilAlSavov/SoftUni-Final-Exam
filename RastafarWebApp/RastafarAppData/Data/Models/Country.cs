using System.ComponentModel.DataAnnotations;

namespace RastafarAppData.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        public List<Camp> Camps { get; set; } = new List<Camp>();
    }
}