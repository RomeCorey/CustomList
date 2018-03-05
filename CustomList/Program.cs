using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers1 = new CustomList<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            numbers2.Add(4);
            numbers2[0] = 7;

        }
    }
}
