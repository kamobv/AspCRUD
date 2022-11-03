using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspCRUD.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int movieId, string movieName)
        {
            return Content(movieId.ToString() + " " + movieName);
        }
    }
}