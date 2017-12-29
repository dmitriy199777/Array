using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<Type> array = new Array<Type> { };

            int size;
            size = array.size();
            Console.WriteLine(size);
            int x = 4;
            Console.ReadKey();
        }
    }
}
