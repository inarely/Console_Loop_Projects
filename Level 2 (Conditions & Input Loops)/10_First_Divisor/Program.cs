using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _10_First_Divisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());           
            
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"\"{i}\" is the smallest divisor of {number}");
                    break;
                }
            }
        }
    }
}
