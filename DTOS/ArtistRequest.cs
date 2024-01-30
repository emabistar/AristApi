using System;
using System.ComponentModel.DataAnnotations;

namespace MusicalApp.DTOS
{
	public class ArtistRequest
	{

        [Required(ErrorMessage = "Name is requied")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Genre is requied")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is requied")]
        public string Country { get; set; } = string.Empty;
        
     
        

    }
}

