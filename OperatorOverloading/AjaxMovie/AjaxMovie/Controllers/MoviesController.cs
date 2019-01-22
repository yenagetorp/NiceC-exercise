using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxMovie.Controllers
{
    public class MoviesController : Controller
    {
        MoviesService service;
        public MoviesController(MoviesService service)
        {
            this.service = service;
        }
        [Route("")]
        
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult GetPartialView(int id)
        {
           
            return PartialView("_MovieBox", service.GetMovieBoxVM(id));
        }


        public IActionResult GetMovieJeson(int id)
        {
           
            return Json(service.GetMovieBoxVM(id));
        }

        public IActionResult GetAllMoviesJeson()
        {
            return Json(service.GetAllMovies());
        }


        //public IActionResult GetPartialView(int id)
        //{
        //    var movie = 
        //        .SingleOrDefault(m => m.MovieId == id);
        //    return PartialView("_MovieBox", movie);
        //}


        //public IActionResult GetMovieJeson(int id)
        //{
        //    var movie = movies
        //        .SingleOrDefault(m => m.MovieId == id);
        //    return Json(movie);
        //}

        //public IActionResult GetMovieJeson()
        //{
        //   // var allMovies[] = movies.ForEach(el =>;)


        //    return Json(allMovies);

        //}

    }
}