using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager;
using MovieManager.Model;

namespace MovieApp.Model
{
    internal class MovieStore
    {
        public static void StartApp()
        {
            MovieManagerClass.movies = SerialDeserial.DeserializeData();

            bool movieAppRunning = true;
            Console.WriteLine();
            Console.WriteLine("Welcome to Movie Store");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            while (movieAppRunning)
            {
               
                Console.WriteLine("Total Movies Available: "+MovieManagerClass.movies.Count);
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display Movies");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. Find Movie");
                Console.WriteLine("5. Delete All movies");
                Console.WriteLine("6. Exit Movie Store");
                Console.WriteLine("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine()); 

                switch(choice)
                {
                    case 1:
                        MovieManagerClass.AddMovie();
                        break;
                    case 2:
                        MovieManagerClass.DisplayMovies();
                        break;
                    case 3:
                        MovieManagerClass.DeleteMovie();
                        break;
                    case 4:
                        MovieManagerClass.FindMovie();
                     break;
                    case 5:
                        MovieManagerClass.ClearAll();
                        break;
                    case 6:
                        movieAppRunning = false;
                       // Environment.Exit(0);
                        break;
                }
            }
        }
        
    }
}
