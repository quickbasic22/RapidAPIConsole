using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidAPIConsole
{
    [Serializable]
    internal class MovieCollection : ICollection<Movie>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Movie item)
        {
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Movie item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Movie[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Movie item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
