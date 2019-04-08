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
            int result = Palin(number);
            if(result == number)
            Console.WriteLine(result + " Is Armstrong");
            else
            Console.WriteLine(result + " Is Not Armstrong");
            Console.ReadLine();
        }

        private static int Palin(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int remain = number % 10;
                Console.WriteLine(remain);
                sum = sum * 10 + remain;
                Console.WriteLine(sum);
                number = number / 10;
            }
            return sum;
        }
    }
}
