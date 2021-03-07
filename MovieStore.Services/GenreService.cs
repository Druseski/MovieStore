using MovieStore.Entities;
using MovieStore.Repositories;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void AddGenre(Genre genre)
        {
            _genreRepository.AddGenre(genre);
        }

        public void DeleteGenre(int genreId)
        {
            _genreRepository.DeleteGenre(genreId);
        }

        public void EditGenre(Genre genre)
        {
            _genreRepository.EditGenre(genre);
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _genreRepository.GetAllGenres();
            return result;
        }

        public Genre GetGenreByID(int id)
        {
            var result = _genreRepository.GetGenreByID(id);
            return result;
        }
    }
}
