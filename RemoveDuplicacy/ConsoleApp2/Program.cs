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
            Console.WriteLine("enter String");
            String word = "     ";
            int[] s = { 1, 2, 3, 3, 4 };
            int[] q = s.Distinct().ToArray();
            for(int counter = 0; counter < q.Length; counter++)
            {
                Console.WriteLine(q[counter]);
            }
            string[] sArray = { "a", "b", "b", "c", "c", "d", "e", "f", "f" };
            string[] updated = sArray.Distinct().ToArray();
            for(int counter = 0; counter < updated.Length; counter++)
            {
                Console.WriteLine(updated[counter]);
            }
            Console.ReadLine();
        }

       static string dup(string words = "Aakash")
        {
            int length = words.Length;
            Console.WriteLine(words + "length " + length);
            return words;
        }
    }
}
