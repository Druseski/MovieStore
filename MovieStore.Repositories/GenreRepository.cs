using MovieStore.Data;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repositories
{
   public class GenreRepository : IGenreRepository
    {
        private readonly DataContext _context;

        public GenreRepository(DataContext context)
        {
            _context = context;
        }

        public void AddGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void DeleteGenre(int genreId)
        {
            Genre genre = GetGenreByID(genreId);
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

        public void EditGenre(Genre genre)
        {
            _context.Update(genre);
            _context.SaveChanges();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _context.Genres.AsEnumerable();
            return result;
        }

        public Genre GetGenreByID(int id)
        {
            var result = _context.Genres.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
