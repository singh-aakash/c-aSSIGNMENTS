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
            int result = fact(number);
            Console.WriteLine("Factorial Is   " + result);
            Console.ReadLine();
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
