using Lab21_25Final.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_25Final.Controllers
{
    public class TempMovieData
    {
        public static List<Movie> Items = new List<Movie>()
        {
            new Movie () {Id = 1, Title = "Dune", Genre = "Sci-Fi", Year = 2001, Actors = "Timothee Chalamet, Zendaya, Jason Momoa", Directors = "Denis Villenauve"}
        };
    }
    public class MovieRegController : Controller
    {
        private List<Movie> _allMovies;
        private object newMoive;

        public MovieRegController()
        {
            _allMovies = TempMovieData.Items;
        }

        // GET: MovieRegController
        public ActionResult Index()
        {
            
            return View(_allMovies);
        }
        public ActionResult UpdatedIndex(Movie newMovie)
        {
            ViewData["movie"] = $"{newMovie.Title} has been added to the registry";
            return View("Index",_allMovies);
        }

        // GET: MovieRegController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieRegController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieRegController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id", "Title", "Genre", "Year", "Actors", "Directors")]Movie newItem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TempMovieData.Items.Add(newItem);
                    return RedirectToAction(nameof(UpdatedIndex),newItem);
                }

                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: MovieRegController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieRegController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieRegController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieRegController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
