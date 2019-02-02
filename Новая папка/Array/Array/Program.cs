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
            try
            {
                int arraySize = 10;
                int largeArraySize = 13;
                int[] someArray = new int[arraySize];

                for(int i = 0; i < largeArraySize; i++)
                {
                    if (i > arraySize)
                    {
                        throw new IndexOutOfRangeException { };
                    }
                    Console.WriteLine(someArray[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }

            Console.ReadLine();
        }
    }
}
