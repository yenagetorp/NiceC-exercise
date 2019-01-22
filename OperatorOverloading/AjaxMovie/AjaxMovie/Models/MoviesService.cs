using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxMovie.Models
{
    public class MoviesService
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie { MovieId=1, Title="Christmas", Description="Classi Christmas moviec"},
            new Movie{ MovieId=2, Title="A beautiful Mind", Description="Classi old moviec"},
            new Movie{ MovieId=3, Title="Love Actually", Description="Classic romance"}
        };

        public MovieBoxVM GetMovieBoxVM(int id)
        {
            var movie =movies
               .SingleOrDefault(m => m.MovieId == id);
            return new MovieBoxVM { Title = movie.Title, Description = movie.Description };
        }

        public MovieBoxVM[] GetAllMovies()
        {
            return movies.Select(m => new MovieBoxVM
            {
                Title=m.Title,
                Description=m.Description
            }).ToArray();
        }


    }
}
