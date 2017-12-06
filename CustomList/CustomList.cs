using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T> : IEnumerable 
    {
        public void ListForTesting(T)
        {
            //Not linked properly??
        }

        public void Add(T)
        {
            
        }

        public void Remove(T)
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
