using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IActorService
    {
        void AddActor(Actor actor);
        void EditActor(Actor actor);
        void DeleteActor(int actorId);

        Actor GetActorByID(int id);

        IEnumerable<Actor> GetAllActors();
    }
}
