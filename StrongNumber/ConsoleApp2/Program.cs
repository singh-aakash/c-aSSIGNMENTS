using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
            int result = strong(number);
            if (result == number)
            {
                Console.WriteLine(result + " is a Strong Number");

            }
            else
                Console.WriteLine(result + " is not a Strong Number");
            Console.ReadLine();
        }

        private static int strong(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int remain = number % 10;
                sum += fact(remain);
                number = number / 10;
            }
            return sum;
        }
        private static int fact(int number)
        {
            int sum = 1;
            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
