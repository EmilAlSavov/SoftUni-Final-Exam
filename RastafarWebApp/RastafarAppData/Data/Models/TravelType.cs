using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppData.Data.Models
{
	public class TravelType
	{
		[Key]
        public int Id { get; set; }

		[Required]
        public string Name { get; set; }

		public List<Post> Posts { get; set; } = new List<Post>();
    }
}
