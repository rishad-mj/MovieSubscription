using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class MovieCollection
    {
        public List<Movie> Movies { get; set; }
    }
}