using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoURL { get; set; }
        public string KnownFor { get; set; }
        public string Awards { get; set; }
        public string Country { get; set; }
        public string ShortBio { get; set; }
        public string OfficialSite { get; set; }
        public string Gender { get; set; }
        public bool Popularyty { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
       

    }
}
