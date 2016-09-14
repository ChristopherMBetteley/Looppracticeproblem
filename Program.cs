using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppracticeproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a console application that asks the user for an integer. If that integer is evenly divisible by 3, 
                then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping) until they win.
            */
            int number;
            while (true)
            {
                Console.WriteLine("Please provide an integer?");
                number = int.Parse(Console.ReadLine());

                if (number % 3 == 0)
                {
                    Console.WriteLine("You Won!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Lost.");
                }
            }
            

        }
    }
}
