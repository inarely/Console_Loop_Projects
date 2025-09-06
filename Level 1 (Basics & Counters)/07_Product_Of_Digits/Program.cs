using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Product_Of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int product = 1;
            int digit;

            while (number > 0)
            {
                digit = number % 10;
                product *= digit;
                number /= 10;
            }
            Console.WriteLine($"Product of digits is: {product}");
        }
    }
}
