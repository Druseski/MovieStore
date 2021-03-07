using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieId);

        Movie GetMovieByID(int id);

        IEnumerable<Movie> GetAllMovie();
    }
}
