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
            int counter = 0;
            int[] numberArray = {9,5,6,8,7,1,4,3,2};
            Array.Sort(numberArray);
            for(counter = 0; counter < numberArray.Length; counter++)
            {
                Console.WriteLine(numberArray[counter]);
            }
            Console.ReadLine();
        }
    }
}
