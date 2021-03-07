using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IWriterService
    {
        void AddWriter(Writer writer);
        void EditWriter(Writer writer);
        void DeleteWriter(int writerId);

        Writer GetWriterByID(int id);

        IEnumerable<Writer> GetAllWriters();
    }
}
