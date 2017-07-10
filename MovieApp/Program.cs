using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> movies = new Dictionary<string, string>();

            movies.Add("Starship Troopers", "SciFi");
            movies.Add("Interstellar", "SciFi");
            movies.Add("Contact", "SciFi");
            movies.Add("The Evil Dead", "Horror");
            movies.Add("Tucker And Dale Vs. Evil", "Horror");
            movies.Add("From Dusk Til Dawn" , "Horror");
            movies.Add("Pulp Fiction" , "Drama");
            movies.Add("American History X" , "Drama");
            movies.Add("True Romance" , "Drama");
            movies.Add("Zootopia" , "Animation");
            movies.Add("Toy Story" , "Animation");
            movies.Add("The Lego Movie" , "Animation");

            bool cont = true;
            string name = GetName();

            while(cont == true)
            {
                cont = DrawMenu(name, movies);
            }
            
        }

        public static string GetName()
        {
            Console.WriteLine("Welcome to the Movie List Application!\nPlease enter your name: \n");
            return Console.ReadLine();
        }

        public static bool DrawMenu(string name, Dictionary<string, string> movies)
        {
            // menu is printed out and the choice is parsed to an int(input is validated)
            Console.WriteLine($"{name}, which genre would you like movies from?\n1) SciFi\n2) Horror\n3) Drama\n4) Animated\n5) Quit\n\n");
            string choice = Console.ReadLine();
            int choiceInt;
            bool cont = true;

            // input is validated
            while (!Int32.TryParse(choice, out choiceInt) && choiceInt != 1 && choiceInt != 2 && choiceInt != 3)
            {
                Console.WriteLine("Sorry, that is not a valid choice.\n");
                Console.WriteLine($"{name}, which genre would you like movies from?\n1) SciFi\n2) Horror\n3) Drama\n4) Animated\n5) Quit\n\n");
                choice = Console.ReadLine();
            }

            // if/else tree handles calls to methods

            if (choiceInt == 1)
            {
                GetSciFi(movies);
            }
            else if (choiceInt == 2)
            {
                GetHorror(movies);
            }
            else if (choiceInt == 3)
            {
                GetDrama(movies);
            }
            else if (choiceInt == 4)
            {
                GetAnimated(movies);
            }
            else
            {
                cont = false;
            }

            return cont;
        }

        public static void GetSciFi(Dictionary<string, string> movies)
        {
            List<string> sciFiMovies = new List<string>();

            foreach (KeyValuePair<string, string> movie in movies)
            {
                if (movie.Value == "SciFi")
                {
                    sciFiMovies.Add(movie.Key);
                }
            }
            foreach (string movie in sciFiMovies)
            {
                Console.WriteLine(movie);
            }

        }

        public static void GetHorror(Dictionary<string, string> movies)
        {
            List<string> horrorMovies = new List<string>();

            foreach (KeyValuePair<string, string> movie in movies)
            {
                if (movie.Value == "Horror")
                {
                    horrorMovies.Add(movie.Key);
                }
            }
            foreach (string movie in horrorMovies)
            {
                Console.WriteLine(movie);
            }
        }

        public static void GetDrama(Dictionary<string, string> movies)
        {
            List<string> dramaMovies = new List<string>();

            foreach (KeyValuePair<string, string> movie in movies)
            {
                if (movie.Value == "Drama")
                {
                    dramaMovies.Add(movie.Key);
                }
            }
            foreach (string movie in dramaMovies)
            {
                Console.WriteLine(movie);
            }

        }

        public static void GetAnimated(Dictionary<string, string> movies)
        {
            List<string> animatedMovies = new List<string>();

            foreach (KeyValuePair<string, string> movie in movies)
            {
                if (movie.Value == "Animation")
                {
                    animatedMovies.Add(movie.Key);
                }
            }
            foreach (string movie in animatedMovies)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
