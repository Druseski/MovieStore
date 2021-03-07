using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repositories
{
   public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int movieId)
        {
            Movie movie = GetMovieByID(movieId);
            _context.Remove(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            _context.Update(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }

        public Movie GetMovieByID(int id)
        {
            var result = _context.Movies.FirstOrDefault(x=>x.Id==id);
            return result;
        }
    }
}
