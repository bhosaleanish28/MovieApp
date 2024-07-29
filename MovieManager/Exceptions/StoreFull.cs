using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    public class StoreFull : Exception
    {
        public StoreFull(string msg):base(msg) 
        { }
    }
}
