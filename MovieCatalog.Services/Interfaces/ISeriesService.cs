using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::MovieCatalog.Data.Models;

namespace MovieCatalog.Services.Interfaces
{
        public interface ISeriesService
        {
            Task<IEnumerable<Series>> GetAllAsync();
            Task<Series?> GetByIdAsync(int id);
            Task AddAsync(Series series);
            Task UpdateAsync(Series series);
            Task DeleteAsync(int id);
        }
}

