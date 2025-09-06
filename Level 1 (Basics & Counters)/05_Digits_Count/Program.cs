using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Digits_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int digit = int.Parse(Console.ReadLine());
            int count = 0;
            int num;

            while (digit > 0)
            {
                num = digit % 10;
                digit /= 10;
                count++;
            }
            Console.WriteLine($"Your number contains \"{count}\" digits.");
        }
    }
}
