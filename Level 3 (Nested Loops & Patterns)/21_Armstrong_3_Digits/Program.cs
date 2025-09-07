using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Armstrong_3_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Three-digit Armstrongs nmbers: ");
            for (int i = 100; i <= 999; i++)
            {
                int digit = i / 100;
                int digit2 = (i / 10) % 10;
                int digit3 = i % 10;

                int sum = (digit * digit * digit) + (digit2 * digit2 * digit2) + (digit3 * digit3 * digit3);

                if(sum == i)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
