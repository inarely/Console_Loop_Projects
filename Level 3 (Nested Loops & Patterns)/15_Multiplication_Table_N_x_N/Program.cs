using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Multiplication_Table_N_x_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number of rows and columns (between 1 - 9): ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (1 <= number && number <= 9)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        for (int j = 1; j <= number; j++)
                        {
                            Console.Write($"{i * j,4}");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else 
                {
                    Console.WriteLine("This number is out of range.");
                    Console.Write("Press any key to retry.");
                    Console.ReadKey();
                }
            }
        }
    }
}
