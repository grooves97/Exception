using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert the divisor");
                string dividendString = Console.ReadLine();
                Console.WriteLine("Insert the dividend");
                string dividerString = Console.ReadLine();

                if (dividerString==""&&dividendString=="")
                {
                    throw new ArgumentException { };
                }

                int dividentInt = int.Parse(dividendString);
                int dividerInt = int.Parse(dividerString);

                if (dividerInt == 0)
                {
                    throw new ArgumentNullException { };
                }

                int result = dividentInt / dividerInt;
                Console.WriteLine($"Result = {result}");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Divider = 0");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Emty");
            }
            Console.ReadLine();
        }
    }
}
