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
            int result = perfect(number);
            if(result == number)
            {
                Console.WriteLine(number + " is a Perfect Number");

            }
            else
            Console.WriteLine(number + " is not a Perfect Number");
            Console.ReadLine();
        }

        private static int perfect(int number)
        {
            int sum = 0;
            for(int i = 1; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
