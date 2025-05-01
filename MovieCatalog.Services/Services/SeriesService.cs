using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Services.Services
{
    using global::MovieCatalog.Data.Models;
    using global::MovieCatalog.Data;
    using global::MovieCatalog.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

    namespace MovieCatalog.Services.Services
    {
        public class SeriesService : ISeriesService
        {
            private readonly MovieCatalogDbContext _context;

            public SeriesService(MovieCatalogDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Series>> GetAllAsync()
            {
                return await _context.Series.ToListAsync();
            }

            public async Task<Series?> GetByIdAsync(int id)
            {
                return await _context.Series.FindAsync(id);
            }

            public async Task AddAsync(Series series)
            {
                _context.Series.Add(series);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Series series)
            {
                _context.Series.Update(series);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var series = await _context.Series.FindAsync(id);
                if (series != null)
                {
                    _context.Series.Remove(series);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

}
