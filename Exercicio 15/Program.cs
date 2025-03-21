
using System.Runtime.InteropServices;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Qual seu peso?");
                double peso = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Qual sua altura em metros? (Utilize virgula para separar os numeros)");
                double altura = Convert.ToDouble(Console.ReadLine());

                double IMC = peso / Math.Pow(altura, 2);

                if (IMC < 18.5)
                {
                    Console.WriteLine($"Voce esta abaixo do peso seu IMC esta em: {IMC.ToString("F2")}");
                    Console.ReadLine();
                }

                else if (IMC >= 18.5 && IMC <= 25)
                {
                    Console.WriteLine($"Voce esta no peso ideal seu IMC esta em: {IMC.ToString("F2")}");
                    Console.ReadLine();
                }

                else if (IMC < 30)
                {
                    Console.WriteLine($"Voce esta acima do peso seu IMC esta em: {IMC.ToString("F2")}");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Voce esta com obesidade seu IMC esta em: {IMC.ToString("F2")}");
                    Console.ReadLine();
                }


            }
        }
    }
}
