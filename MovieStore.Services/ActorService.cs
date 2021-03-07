using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class ActorService :IActorService
    {
        private readonly IActorRepository _authorRepository;

        public ActorService(IActorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void AddActor(Actor actor)
        {
            _authorRepository.AddActor(actor);
        }

        public void DeleteActor(int actorId)
        {
            _authorRepository.DeleteActor(actorId);
        }

        public void EditActor(Actor actor)
        {
            _authorRepository.EditActor(actor);
        }

        public Actor GetActorByID(int id)
        {
            var result = _authorRepository.GetActorByID(id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _authorRepository.GetAllActors();
            return result;
        }
    }
}
