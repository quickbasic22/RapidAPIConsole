using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace RapidAPIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Object> collection = new Dictionary<string, object>();
            
            List<Movie> movies = new List<Movie>
            {
               new Movie()
               {
                   IMDBID = "tt2673203",
                   MovieTitle = "A Glitch in the Matrix",
                   Released = 2021
               },
               new Movie()
               {
                   IMDBID = "tt1974203",
                   MovieTitle = "Adventures in Odyssey: Escape from the Forbidden Matrix",
                   Released = 2001
                },
                 new Movie()
                 {
                     IMDBID = "tt0109151",
                     MovieTitle = "Armitage III: Poly Matrix",
                     Released = 1996
                 }
            };
            
            collection.Add("movie_results", movies);
            collection.Add("search_results", 23);
            collection.Add("status", "OK");
            collection.Add("status_message", "Query was successful");



            var serialMovies = JsonConvert.SerializeObject(collection);

            var moviestring = serialMovies.ToString();

            Console.WriteLine(moviestring);

            Console.ReadKey();
        }

    }

}
