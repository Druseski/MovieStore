using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string MovieTitle { get; set; }
        public string Discription { get; set; }
        public string DirectorName { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int MovieDuration { get; set; }
        public string GenreName { get; set; }
        public string  Country{ get; set; }
        public string Production { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string WriterName { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        public string ActorName { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public double Rating { get; set; }
        public int UserID { get; set; }
        public string PhotoURL { get; set; }
        public string TrailerURL { get; set; }
        public string FilmingLocations { get; set; }
        public string Language { get; set; } 
        public int Budget { get; set; }
        public double Price { get ; set; }
        public string Awards { get; set; }
        public DateTime DateAdded { get; set; }








    }
}
