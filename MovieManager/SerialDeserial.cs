using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace MovieManager.Model
{
    public class SerialDeserial
    {
        public static string filepath = ConfigurationManager.AppSettings["jsonfile"];
        public static void SerializeData(List<Movie> movies)
        {
            string json = JsonConvert.SerializeObject(movies);
            File.WriteAllText(filepath, json);
        }

        public static List<Movie> DeserializeData()
        {
            List<Movie> movies = new List<Movie>();
            string filename = filepath;
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            return movies;
        }
    }
}
