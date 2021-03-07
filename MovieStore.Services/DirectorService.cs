using MovieStore.Entities;
using MovieStore.Repositories;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class DirectorService :IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void AddDirector(Director director)
        {
            _directorRepository.AddDirector(director);
        }

        public void DeleteDirector(int directorId)
        {
            _directorRepository.DeleteDirector(directorId);
        }

        public void EditDirector(Director director)
        {
            _directorRepository.EditDirector(director);
        }

        public IEnumerable<Director> GetAllDirector()
        {
            var result = _directorRepository.GetAllDirector();
            return result;
        }

        public Director GetDirectorByID(int id)
        {
            var result = _directorRepository.GetDirectorByID(id);
            return result;
        }
    }
}
