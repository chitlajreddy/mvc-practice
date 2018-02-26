using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapp1.Models
{
    public class Movies
    {
        public string ISBN_13 { get; set; }
        public string Title { get; set; }

        public string category{ get; set; }

        public List<Movies> movieinfo { get; set; }
    }
}