using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Model
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int MovieYear { get; set; }
        public string MovieID { get; set; }
        public static int count = 0;

        public Movie()
        {
            count++;
        }
    }
}
