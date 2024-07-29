using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    public class NoMovie:Exception
    {
        public NoMovie(string msg):base(msg) 
        { }
    }
}
