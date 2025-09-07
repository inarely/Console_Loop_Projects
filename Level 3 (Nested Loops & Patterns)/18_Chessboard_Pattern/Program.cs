using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Chessboard_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the size of the chessboard (width and height): ");
                int number = int.Parse(Console.ReadLine());
                if (number >= 1)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        for (int j = 1; j <= number; j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                Console.Write("#");
                            }
                            else
                            {
                                Console.Write(".");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect number. Please enter the number greater than 0.");
                    Console.WriteLine("Press any key to retry.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
