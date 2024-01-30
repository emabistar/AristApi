using System;
using MusicalApp.DTOS;
using MusicalApp.Models;
using MusicalApp.Repositories;

namespace MusicalApp.Services
{
	public class ArtistService : IArtistService
	{
		private readonly IArtistrepository _repos;
		public ArtistService(IArtistrepository repos)
		{
			_repos= repos;
		}
        public async Task<Response<List<Artist>>> GetAllArtistAsync()
        {
            var response = new Response<List<Artist>>();
            var artists = await _repos.GetAllArtistAsync();
            response.Data = artists;
            return response;

           
        }

        public async Task<Response<Artist>> CreateArtistAsync(ArtistRequest artistrequest)
        {

            var response = new Response<Artist>();
            var artist = new Artist
            {
                Name = artistrequest.Name,
                Genre = artistrequest.Genre,
                Country = artistrequest.Country
            };
            var createdArtist = await _repos.CreateArtistAsync(artist);
            response.Data = createdArtist;
            response.Success = true;
            response.Message = "Artist created";
            return response;
        }

        public  async Task<Response<bool>> DeleteArtistAsync(int id)
        {
            var response = new Response<bool>();
            var deleted = await _repos.DeleteArtistAsync(id);
            response.Data = deleted;
            return response;
        }

       

        public async Task<Response<Artist>> GetArtistByIdAsync(int id)
        {
            var response = new Response<Artist>();
            var artist = await _repos.GetArtistByIdAsync(id);
            if(artist == null)
            {
                response.Success = false;
                response.Message = "Artist not found";
                return response;
            }
            response.Data = artist;
            return response;
        }

        public async Task<Response<Artist>> UpdateArtistAsync(int id, ArtistRequest artistRequest)
        {
            var response = new Response<Artist>();
            var artist = await _repos.GetArtistByIdAsync(id);
            if(artist == null)
            {
                response.Success= false;
                response.Message = " Artist not found";
                return response;
            }
            artist.Name = artistRequest.Name;
            artist.Genre = artistRequest.Genre;
            artist.Country = artistRequest.Country;
            var updateArtist = await _repos.UpdateArtistAsync(artist);
            response.Data = updateArtist;
            return response;
        }
    }
}

