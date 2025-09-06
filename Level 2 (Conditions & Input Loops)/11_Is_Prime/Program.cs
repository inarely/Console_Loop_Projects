using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Is_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number greater than 1:  ");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"First divisor (other than 1) is \"{i}\". The number is composite.");
                    break;
                }
                else
                {
                    Console.WriteLine($"No divisors found. The number is prime.");
                    break;
                }
            }
        }
    }
}
