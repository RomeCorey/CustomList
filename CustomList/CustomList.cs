using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {        
        private int count;
        private int capacity;
        T[] ArrayOne;
        T[] tempArray;

        public CustomList() 
        {
            capacity = 10;
            ArrayOne = new T[capacity];
            tempArray = new T[0];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public T this[int i]
        {
            get
            {
                return ArrayOne[i];
            }
            set
            {
                ArrayOne[i] = value;
            }
        }

        public void Add(T item)
        {
            Console.WriteLine(this.Count);
            if(Count == capacity)
            {
                GetAddArray();
            }
            ArrayOne[Count] = item;
            count++;
        }

        public void GetAddArray()
        {
            T[] tempArray = new T[capacity * 2];
             for(int i = 0; i < count; i++)
            {
                tempArray[i] = ArrayOne[i];
            }
            capacity = capacity * 2;
            ArrayOne = tempArray;

        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
                if (ArrayOne[i].Equals(item))
                {
                    ArrayOne[i] = ArrayOne[i + 1];
                    count++;
                        return true;
                }
            return false;        
        }

        

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    
    }
}
