using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int sum = 0;

            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine($"Sum of digits is: {sum}");
        }
    }
}
