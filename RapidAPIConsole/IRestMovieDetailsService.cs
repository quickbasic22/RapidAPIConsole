using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RapidAPIConsole
{
    internal interface IRestMovieDetailsService<T>
    {
        Task<IEnumerable<T>> GetMovieDetails(string imdbId);
    }
}
