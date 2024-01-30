using System;
using System.ComponentModel.DataAnnotations;

namespace MusicalApp.Models
{
	public class Artist
	{
		public  int Id { get; set; }

		[Required(ErrorMessage = "Name is requied")]
		public string Name { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
 
