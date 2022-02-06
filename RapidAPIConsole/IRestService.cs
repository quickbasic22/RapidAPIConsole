using System.Collections.Generic;
using System.Threading.Tasks;

namespace RapidAPIConsole
{
    internal interface IRestMovieService<T>
    {
        Task<IEnumerable<T>> GetMovies(string title);
       
       
    }
}