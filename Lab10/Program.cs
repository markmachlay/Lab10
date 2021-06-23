using System;
using System.Collections.Generic;
using System.Net;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine("There are many movies in the list");
            char continueFlag;
            do
            {
                Console.WriteLine("Please select a genre" + "\r\n" +
               "1. Horror" + "\r\n" +
               "2. Drama" + "\r\n" +
               "3. Sci-Fi" + "\r\n" +
               "4. Animated");
                var userInput = Console.ReadLine();

                var validate = IsUserValid(userInput);

                var result = SelectAGenre(validate);

                DisplayMoviesInGenre(result);
                Console.WriteLine("Would you like to continue? (y/n)");
                continueFlag = Console.ReadLine().ToLower()[0];
            } while (continueFlag == 'y');
           
        }

        static string IsUserValid(string userInput)
        {
            if(string.IsNullOrEmpty(userInput))
            {
                var response = string.Empty;
                do
                {
                    Console.WriteLine("Please enter a number");
                    response = Console.ReadLine();
                } while (response == null);

                return response;
            }
            else
            {
                return userInput;
            }
        }

        static string SelectAGenre(string validate)
        {
            if(validate == "1" || validate == "Horror")
            {
                return "Horror";
            }
            else if(validate == "2" || validate == "Drama")
            {
                return "Drama";
            }
            else if(validate == "3" || validate == "Sci-Fi")
            {
                return "Sci-Fi";
            }
            else
            {
                return "Animated";
            }
        }

        static void DisplayMoviesInGenre(string result)
        {
            Movie movies = new Movie();

            var chosenMovies = movies.DisplayMovieList();

            foreach (var movie in chosenMovies)
            {
                if (result == movie.Category)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }
}
