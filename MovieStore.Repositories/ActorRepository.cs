using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        public ActorRepository(DataContext context)
        {
            _context = context;
        }

        public void AddActor(Actor actor)
        {
            _context.Director.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(int actorId)
        {
            Actor actor = GetActorByID(actorId);
            _context.Director.Remove(actor);
            _context.SaveChanges();
        }

        public void EditActor(Actor actor)
        {
            _context.Director.Update(actor);
            _context.SaveChanges();
        }

        public Actor GetActorByID(int id)
        {
            var result = _context.Director.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _context.Director.AsEnumerable();
            return result;
        }
    }
}
