using System;
using MusicalApp.DTOS;
using MusicalApp.Models;

namespace MusicalApp.Services
{
	public interface IArtistService
	{

		Task<Response<List<Artist>>> GetAllArtistAsync();
        Task<Response<Artist>> GetArtistByIdAsync(int id);
        Task<Response<Artist>> CreateArtistAsync(ArtistRequest artist);
        Task<Response<Artist>> UpdateArtistAsync(int id, ArtistRequest artistRequest);
        Task<Response<bool>>DeleteArtistAsync(int id);



    }
}

