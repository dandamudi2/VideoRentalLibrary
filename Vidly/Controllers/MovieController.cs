using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private readonly VidlyDataContext _vidlyDataContext;
        public MovieController()
        {
            _vidlyDataContext = new VidlyDataContext();
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [HttpGet]
        public ActionResult Index(int? pageIndex,string sortBy)
        {

            var movies = _vidlyDataContext.Movies.Include(c => c.Genre);
            return View(movies);
        }

        [Route("movie/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByreleaseDate(int year,int month)
        {
            return Content(string.Format("year {0} , month {1}", year, month));
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var _movie = _vidlyDataContext.Movies.Include(c => c.Genre).Where(x => x.Id == id).FirstOrDefault();
            return View(_movie);
        }
    }
}