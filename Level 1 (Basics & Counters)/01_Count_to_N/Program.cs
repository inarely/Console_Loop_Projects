using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"Numbers from 1 to {number}: ");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
            }
        }
    }
}
