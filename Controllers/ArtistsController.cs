using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicalApp.DTOS;
using MusicalApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicalApp.Controllers

{

    [ApiController]

    [Route("api/[controller]")]
    public class ArtistsController : Controller
    {
        private readonly IArtistService _artistService;

        public ArtistsController (IArtistService artistService)
        {
            _artistService = artistService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllArtistsAsync()
        {
            return Ok(await _artistService.GetAllArtistAsync());
           
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAllArtistsByIdAsync(int id)
        {

            return Ok(await _artistService.GetArtistByIdAsync(id));

        }

        [HttpPost]
        public async Task<IActionResult> CreateArtistAsync([FromBody] ArtistRequest artistRequest)
        {

            return Ok(await _artistService.CreateArtistAsync(artistRequest));

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtistAsync(int id , [FromBody] ArtistRequest artistRequest)
        {

            return Ok(await _artistService.UpdateArtistAsync(id,artistRequest));

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteArtistAsync(int id)
        {

            return Ok(await _artistService.DeleteArtistAsync(id));

        }






    }
}

