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
            int result = Arms(number);
            if(result == number)
            Console.WriteLine(result + " is Armstrong number");
            else
            Console.WriteLine(result + " is not Armstrong number");
            Console.ReadLine();
        }

        private static int Arms(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int remain = number % 10;
                Console.WriteLine(remain);
                sum += remain * remain * remain;
                //Console.WriteLine(sum);
                number = number/10;
                //Console.WriteLine(number);
            }
            return sum;
        }
    }
}
