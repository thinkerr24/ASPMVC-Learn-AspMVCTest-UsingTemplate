using AspMVCFirst.Models;
using System.Web.Mvc;
using System.Linq;
using System;

namespace AspMVCFirst.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        public ActionResult Index()
        {
            var movies = from m in db.Movies
                         where m.ReleaseDate > new DateTime(2010, 6, 1)
                         select m;
            return View(movies.ToList());
        }
        // 这个Create用来创建页面
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}