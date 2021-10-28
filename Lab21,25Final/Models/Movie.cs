using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_25Final.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Range(1880, 2021)]
        public int Year { get; set; }
        [Required]
        public string Actors { get; set; }
        [Required]
        public string Directors { get; set; }
       

    }
}
