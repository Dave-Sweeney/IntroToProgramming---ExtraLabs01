using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming___ExtraLabs01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 0;
            bool validInput = false;

            do
            {
                Console.WriteLine("How big do you want the grid?");
                try
                {
                    gridSize = Int32.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    validInput = false;
                    Console.WriteLine("Nope. Not a valid number. Try again!");
                }
            } while (!validInput);
            
            

            GenerateGrid(gridSize);

            Console.ReadKey();
        }

        public static void GenerateGrid(int size)
        {
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                              
                Console.WriteLine();
            }
        }


    }
}
