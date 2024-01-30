using System;
using MusicalApp.Models;

namespace MusicalApp.Repositories
{
	public interface IArtistrepository
	{
		Task<List<Artist>> GetAllArtistAsync();
		Task<Artist> GetArtistByIdAsync(int id);
		Task<Artist> CreateArtistAsync(Artist artist);
		Task<Artist> UpdateArtistAsync(Artist artist);
		Task<bool> DeleteArtistAsync(int id);
	}
}

