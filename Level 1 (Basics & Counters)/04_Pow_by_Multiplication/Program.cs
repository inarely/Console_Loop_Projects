using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pow_by_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base (A): ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter base (B): ");
            int pow = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
            Console.WriteLine($"{number}^{pow} = {result}");
        }
    }
}
