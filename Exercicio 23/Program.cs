﻿namespace Exercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  numeros = "";

            for(int i = 1; i <= 100; i ++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    numeros = "FizzBuzz";
                    Console.WriteLine(numeros);
                }
                else if (i % 3 == 0)
                {
                  numeros = "Fizz";
                    Console.WriteLine(numeros);
                }

                else if(i % 5 == 0)
                {
                    numeros = "Buzz";
                    Console.WriteLine(numeros);
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
