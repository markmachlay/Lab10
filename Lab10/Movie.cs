using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Movie
    {

        public string Category { get; set; }

        public string Title { get; set; }
        
        public Movie()
        {

        }

        public Movie(string category, string title)
        {
            Category = category;
            Title = title;
        }

        public List<Movie> DisplayMovieList()
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Horror", "Saw"));
            movieList.Add(new Movie("Horror", "Halloween"));
            movieList.Add(new Movie("Horror", "Cabin in the Woods"));
            movieList.Add(new Movie("Horror", "Final Destination"));
            movieList.Add(new Movie("Animated", "The Iron Giant"));
            movieList.Add(new Movie("Animated", "My Neighbor Totoro"));
            movieList.Add(new Movie("Animated", "An American Tale"));
            movieList.Add(new Movie("Animated", "The Lion King"));
            movieList.Add(new Movie("Drama", "American Beauty"));
            movieList.Add(new Movie("Drama", "Good Will Hunting"));
            movieList.Add(new Movie("Drama", "Casablanca"));
            movieList.Add(new Movie("Drama", "The Godfather"));
            movieList.Add(new Movie("Sci-Fi", "The Matrix"));
            movieList.Add(new Movie("Sci-Fi", "Alien"));
            movieList.Add(new Movie("Sci-Fi", "Inception"));
            movieList.Add(new Movie("Sci-Fi", "Star Wars: Empire Strikes Back"));

            return movieList; 
        }








    }
}
