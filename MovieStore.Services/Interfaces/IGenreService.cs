using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IGenreService
    {
        void AddGenre(Genre genre);
        void EditGenre(Genre genre);
        void DeleteGenre(int genreId);

        Genre GetGenreByID(int id);

        IEnumerable<Genre> GetAllGenres();
    }
}
