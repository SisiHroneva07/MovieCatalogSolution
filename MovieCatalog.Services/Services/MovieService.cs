using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Services.Services
{
    using global::MovieCatalog.Data.Models;
    using global::MovieCatalog.Data;
    using global::MovieCatalog.Services.Interfaces.MovieCatalog.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;


    namespace MovieCatalog.Services.Services
    {
        public class MovieService : IMovieService
        {
            private readonly MovieCatalogDbContext _context;

            public MovieService(MovieCatalogDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Movie>> GetAllAsync()
            {
                return await _context.Movies.ToListAsync();
            }

            public async Task<Movie?> GetByIdAsync(int id)
            {
                return await _context.Movies.FindAsync(id);
            }

            public async Task AddAsync(Movie movie)
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Movie movie)
            {
                _context.Movies.Update(movie);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var movie = await _context.Movies.FindAsync(id);
                if (movie != null)
                {
                    _context.Movies.Remove(movie);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

}
