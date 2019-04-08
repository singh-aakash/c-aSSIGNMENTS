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
            int result = fab(number);
            Console.WriteLine("fibonacci Is   " + result);
            Console.ReadLine();
        }

        private static int fab(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
                Console.WriteLine(number + ", ");
            return fab(number - 1) + fab(number - 2);
        }
    }
}
