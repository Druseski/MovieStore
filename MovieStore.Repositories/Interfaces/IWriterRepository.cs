using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repositories.Interfaces
{
   public interface IWriterRepository
    {
        void AddWriter(Writer writer);
        void EditWriter(Writer writer);
        void DeleteWriter(int writerId);

        Writer GetWriterByID(int id);

        IEnumerable<Writer> GetAllWriters();
    }
}
