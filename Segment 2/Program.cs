using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberCorrect = false;
            int randomNumber = 42;

            Console.WriteLine("Guess a number between 1 and 100 ?");
            do
            {
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                    numberCorrect = true;
                    Console.WriteLine("Correct");
                }
                else
                    Console.WriteLine("Incorrect");
            } while (!numberCorrect);
            Console.ReadLine();
        }
    }
}
