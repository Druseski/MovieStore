using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repositories.Interfaces
{
    public interface IActorRepository
    {
        void AddActor(Actor actor);
        void EditActor(Actor actor);
        void DeleteActor(int actorId);

        Actor GetActorByID(int id);

        IEnumerable<Actor> GetAllActors();
    }
}
