using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Data.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [MaxLength(100)]
        public string Genre { get; set; }

        [MaxLength(100)]
        public string Director { get; set; }
    }
}

