using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }

        public void EditMovie(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            var result = _movieRepository.GetAllMovie();
            return result;
        }

        public Movie GetMovieByID(int id)
        {
            var result = _movieRepository.GetMovieByID(id);
            return result;
        }
    }
}
