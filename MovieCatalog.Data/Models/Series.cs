using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Data.Models
{
    public class Series
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public int StartYear { get; set; }

        public int? EndYear { get; set; } 

        [MaxLength(100)]
        public string Genre { get; set; }

        [MaxLength(100)]
        public string Creator { get; set; }
    }
}

