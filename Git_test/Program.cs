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
            Random r = new Random();
            Console.WriteLine("Hello, World!!");
            Console.WriteLine("Enter the Starting number please.");


            string temp_first = Console.ReadLine();
            int first_num = Convert.ToInt32(temp_first);

            Console.WriteLine("Enter the ending number please.");

            string temp_second = Console.ReadLine();
            int second_num = Convert.ToInt32(temp_second);

            Console.WriteLine(second_num);

            if (first_num > second_num)
            {
                int temp;
                temp = first_num;
                first_num = second_num;
                second_num = temp;
            }

            int correct_number;
            correct_number = r.Next(first_num, second_num);

            Console.WriteLine("Guess a number!");

            string first_guess = Console.ReadLine();
            int number = Convert.ToInt32(first_guess);

            while (number != correct_number)
            {
                Console.WriteLine("Try again :(");
                first_guess = Console.ReadLine();
                number = Convert.ToInt32(first_guess);
            }

            Console.WriteLine("You are correct!!");
            Console.ReadKey();
        }
    }
}
