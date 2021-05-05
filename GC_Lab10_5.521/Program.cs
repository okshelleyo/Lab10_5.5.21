using System;
using System.Collections.Generic;

namespace GC_Lab10_5._521
{
    class Program
    {
        //animated, drama, horror, scifi

        static void Main(string[] args)
        {

            //each movie is an object and we're creating a list of objects and then going through the list of objects to call a specific piece of data from them.

            Movie nemo = new Movie("Finding Nemo", "animated");
            Movie toyStory = new Movie("Toy Story", "animated");
            Movie cars = new Movie("Cars", "animated");
            Movie ladyBird = new Movie("Lady Bird", "drama");
            Movie littleWomen = new Movie("Little Women", "drama");
            Movie pridePrejudice = new Movie("Pride and Prejudice", "drama");
            Movie saw = new Movie("Saw", "horror");
            Movie shining = new Movie("The shining", "horror");
            Movie starWars = new Movie("Star Wars", "scifi");
            Movie galaxyQuest = new Movie("Galaxy Quest", "scifi");


            List<Movie> moviesList = new List<Movie>
            {
                nemo, toyStory, cars, ladyBird, littleWomen, pridePrejudice, saw, shining, starWars, galaxyQuest
            };
            
            moviesList.Sort();
            
            List<string> genres = new List<string> { "scifi", "horror", "animated", "drama" };
            bool keepPlaying = true;          

            Console.WriteLine("Welcome to the Movie List Application!");

            while (keepPlaying)
            {                               
                string input = GetUserInput("What genre are you interested in? Choose from animated, drama, horror, and scifi", genres);

                // if user input  = the genre, print the movie title                
                
                foreach (Movie item in moviesList)
                {
                    if (input == item.Category)
                    {
                        item.PrintTitle();
                    }

                }

                Console.WriteLine("Continue? (y/n)");
                string userPlay = Console.ReadLine();

                if (userPlay == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }

            }

        }

        public static string GetUserInput(string message, List<string> list)
        {
            
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            bool check = true;
            int checker = 0;

            while (check)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (input == list[i])
                    {
                        checker++;
                    }                   
                }
                if (checker != 0)
                {
                    check = false;
                }
                else 
                {
                    Console.WriteLine("Incorrect input. " + message);
                    input = Console.ReadLine();
                }
            }

            return input;
        }
    }
}
