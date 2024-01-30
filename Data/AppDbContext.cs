using System;
using Microsoft.EntityFrameworkCore;
using MusicalApp.Models;

namespace MusicalApp.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
		{
		}
		public DbSet<Artist> Artists { get; set; } = null!;
	}


}

