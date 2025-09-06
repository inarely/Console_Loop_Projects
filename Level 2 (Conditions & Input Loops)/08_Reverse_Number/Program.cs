using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Reverse_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int digit;
            Console.Write("Reversed number (Without \"0\"): ");

            do
            {
                if (number == 0)
                {
                    Console.WriteLine($"Seriosly: {number}?");
                    break;
                }

                
                digit = number % 10;
                if (digit != 0)
                {               
                Console.Write(digit);
                }
                number /= 10;
            }
            while (number != 0);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
