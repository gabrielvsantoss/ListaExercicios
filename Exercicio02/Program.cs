using System.Runtime.InteropServices;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 0, altura = 0;

            Console.WriteLine("Qual o valor do raio em cm?");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura em cm?");
            altura = Convert.ToDouble(Console.ReadLine());

           double volume = Math.PI * Math.Pow(raio, 2) * altura;
 
            Console.WriteLine($"volume é de {volume}cm³");
            Console.ReadLine();
        }
    }
}
