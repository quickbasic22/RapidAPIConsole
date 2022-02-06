using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.ComponentModel;

namespace RapidAPIConsole
{ 
    internal class RestService : IRestMovieService<Movie>, IRestMovieDetailsService<MovieDetails>
    {
        StreamReader reader;
        IEnumerable<Movie> movies1;

        public async Task<IEnumerable<Movie>> GetMovies(string title)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tvshows-data-imdb.p.rapidapi.com/?type=get-movies-by-title&title=" + title),
                Headers =
    {
        { "x-rapidapi-host", "movies-tvshows-data-imdb.p.rapidapi.com" },
        { "x-rapidapi-key", "1133a1d233msha5430808364bb92p1f1148jsnfba4ce9df103" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(body);


                
                var jsonOptions = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

               

                Debug.WriteLine(response.RequestMessage.Content.ToString());

               

            }
            IEnumerable<Movie> movies = new List<Movie>();
            return movies;
           
        }

        public Task<IEnumerable<MovieDetails>> GetMovieDetails(string imdbId)
        {
            throw new NotImplementedException();
        }

    }
}
