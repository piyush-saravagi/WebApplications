using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class MoviesController : Controller
    {
        private static List<Movie> moviesList = new List<Movie> {
            new Movie{ Name="Shrek", Id=1},
            new Movie{ Name="Shrek 2", Id=2},
            new Movie{ Name="Titanic", Id=3},
        };
        // GET: Movies
        public ActionResult Index()
        {
            return View(moviesList);
        }

        public ActionResult Delete(int Id) {
            Movie movieToRemove = null;
            foreach (Movie m in moviesList) {
                if (m.Id == Id) {
                    movieToRemove = m;
                }
            }
            if (movieToRemove != null)
                moviesList.Remove(movieToRemove);
            else
                throw new KeyNotFoundException($"Cannot delete. Movie with id {Id} not found");
            return RedirectToAction("Index");
            //return Content("Deleted movie with it");
        }
    }
}