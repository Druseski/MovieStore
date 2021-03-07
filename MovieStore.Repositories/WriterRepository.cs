using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repositories
{
   public class WriterRepository : IWriterRepository
    {
        readonly DataContext _context;

        public WriterRepository(DataContext context)
        {
            _context = context;
        }

        public void AddWriter(Writer writer)
        {
            _context.Writers.Add(writer);
            _context.SaveChanges();
        }

        public void DeleteWriter(int writerId)
        {
            Writer writer = GetWriterByID(writerId);
            _context.Writers.Remove(writer);
            _context.SaveChanges();
        }

        public void EditWriter(Writer writer)
        {
            _context.Writers.Update(writer);
            _context.SaveChanges();
        }

        public IEnumerable<Writer> GetAllWriters()
        {
            var result = _context.Writers.AsEnumerable();
            return result;
        }

        public Writer GetWriterByID(int id)
        {
            var result = _context.Writers.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
