using MovieStore.Data;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        readonly DataContext _context;

        public DirectorRepository(DataContext context)
        {
            _context = context;
        }



        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(int directorId)
        {
            Director director = GetDirectorByID(directorId);
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void EditDirector(Director actor)
        {
            _context.Directors.Update(actor);
            _context.SaveChanges();
        }

        public Director GetDirectorByID(int id)
        {
            var result = _context.Directors.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Director> GetAllDirector()
        {
            var result = _context.Directors.AsEnumerable();
            return result;
        }

    }

}
