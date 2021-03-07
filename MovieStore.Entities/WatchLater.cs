using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class WatchLater
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
