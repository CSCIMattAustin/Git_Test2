using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!!");
            Console.WriteLine("Guess a number!");
            int number = Console.Read();
            while(number != 42)
            {
                Console.WriteLine("Try again :(");
                number = Console.Read();
            }
           
        }
    }
}
