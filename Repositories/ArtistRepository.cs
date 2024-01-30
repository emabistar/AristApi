using System;
using Microsoft.EntityFrameworkCore;
using MusicalApp.Data;
using MusicalApp.Models;

namespace MusicalApp.Repositories
{
	public class ArtistRepository:IArtistrepository
	{
        readonly private AppDbContext _context;
		public ArtistRepository(AppDbContext context)
		{
            _context = context;
		}

        public async  Task<Artist> CreateArtistAsync(Artist artist)
        {
            _context.Artists.Add(artist);
            await _context.SaveChangesAsync();
           return artist;
           
        }
        public  async Task<List<Artist>> GetAllArtistAsync()
        {
            return await _context.Artists.ToListAsync();
        }

        public async Task<bool> DeleteArtistAsync(int id)
        {
            var artist = await GetArtistByIdAsync(id);
            _context.Remove(artist);
            await _context.SaveChangesAsync();
            return true;

        }

       

        public async Task<Artist>  GetArtistByIdAsync(int id)
        {
            return  await _context.Artists.FindAsync(id);

            
        }

        public async Task<Artist> UpdateArtistAsync(Artist artist)
        {
            _context.Artists.Update(artist);
            await _context.SaveChangesAsync();
            return artist;

        }
    }
}

