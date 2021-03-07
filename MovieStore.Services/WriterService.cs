using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class WriterService : IWriterService
    {
        private readonly IWriterRepository _writerRepository;

        public WriterService(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }

        public void AddWriter(Writer writer)
        {
            _writerRepository.AddWriter(writer);
        }

        public void DeleteWriter(int writerId)
        {
            _writerRepository.DeleteWriter(writerId);

        }

        public void EditWriter(Writer writer)
        {
            _writerRepository.EditWriter(writer);
        }

        public IEnumerable<Writer> GetAllWriters()
        {
            var result = _writerRepository.GetAllWriters();
            return result;
        }

        public Writer GetWriterByID(int id)
        {
            var result = _writerRepository.GetWriterByID(id);
            return result;
        }
    }
}
