using MovieCatalog.Data;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieCatalog.Presentation



{
    internal class Program
    {
        static void Main(string[] args)
        {

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
