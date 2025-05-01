using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::MovieCatalog.Data.Models;

namespace MovieCatalog.Services.Interfaces
{
    

    namespace MovieCatalog.Services.Interfaces
    {
        public interface IMovieService
        {
            Task<IEnumerable<Movie>> GetAllAsync();
            Task<Movie?> GetByIdAsync(int id);
            Task AddAsync(Movie movie);
            Task UpdateAsync(Movie movie);
            Task DeleteAsync(int id);
        }
    }

}
