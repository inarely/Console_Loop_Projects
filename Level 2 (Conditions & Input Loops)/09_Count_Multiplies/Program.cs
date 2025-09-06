using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Count_Multiplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int divisibleBy3 = 0;
            int countOfDigits = 0;

            Console.WriteLine();

            Console.Write("( ");
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    divisibleBy3 = i;
                    countOfDigits++;
                    Console.Write($"\"{divisibleBy3}\" ");
                }
            }
            Console.WriteLine(")");
            Console.Write($"{countOfDigits} numbers divisible by \"3\" but not by \"5\".");
            Console.WriteLine($" From 1 to {number}.");
        }
    }
}
