using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repositories
{
   public interface IDirectorRepository
    {
        void AddDirector(Director director);
        void EditDirector(Director director);
        void DeleteDirector(int directorId);

        Director GetDirectorByID(int id);

        IEnumerable<Director> GetAllDirector();
    }
}
