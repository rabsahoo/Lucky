using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);

           
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number:(between 1 to 10) ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
            Console.WriteLine("Secret is " + number);
        }
    }
}
