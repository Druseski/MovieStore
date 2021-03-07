using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IDirectorService
    {
        void AddDirector(Director director);
        void EditDirector(Director director);
        void DeleteDirector(int directorId);

        Director GetDirectorByID(int id);

        IEnumerable<Director> GetAllDirector();
    }
}
