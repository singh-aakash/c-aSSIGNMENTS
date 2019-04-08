using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter choice \n 1.Addition \n 2.Substraction \n 3.Multiplication" +
                "\n 4.Division \n");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter First Number");
                    int firstnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int secondnumber = int.Parse(Console.ReadLine());
                    result = firstnumber + secondnumber;
                    Console.WriteLine("result = " + result);
                    break;
                case 2:
                    Console.WriteLine("Enter First Number");
                    firstnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    secondnumber = int.Parse(Console.ReadLine());
                    result = firstnumber - secondnumber;
                    Console.WriteLine("result = " + result);
                    break;
                case 3:
                    Console.WriteLine("Enter First Number");
                    firstnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    secondnumber = int.Parse(Console.ReadLine());
                    result = firstnumber * secondnumber;
                    Console.WriteLine("result = " + result);
                    break;
                case 4:
                    Console.WriteLine("Enter First Number");
                    firstnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    secondnumber = int.Parse(Console.ReadLine());
                    float results = firstnumber / secondnumber;
                    Console.WriteLine("result = " + results);
                    break;
                default:
                    Console.WriteLine("Enter valid Number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
