using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_25Final.Models
{
    public class Movie
    {
        //public Movie() { }
        //public Movie(MovieViewModel model)
        //{
        //    this.Id = model.Id;
        //    this.Title = model.Title;
        //    this.Genre = model.Genre;
        //    this.Year = model.Year;

        //    var actorsSplit = model.Actors.Split(",").ToList();
        //    var DirectorSplit = model.Actors.Split(",").ToList();
        //}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public double Runtime { get; set; }


        //[Range(1880, 2021)]
        //public int Year { get; set; }
        //[Required]
        //public string Actors { get; set; }
        ////public List<string> Actors { get; set; } = new List<string>();
        //[Required]
        //public string Directors { get; set; }
        ////public List<string> Directors { get; set; } = new List<string>();




        //public class MovieViewModel
        //{
        //    [Required]
        //    public int Id { get; set; }
        //    [StringLength(50)]
        //    public string Title { get; set; }
        //    [Required]
        //    public string Genre { get; set; }
        //    [Range(1880, 2021)]
        //    public int Year { get; set; }
        //    [Required]
        //    public string Actors { get; set; }

        //    [Required]
        //    public string Directors { get; set; }


        //}
    }



}
