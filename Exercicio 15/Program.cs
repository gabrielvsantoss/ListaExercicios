
namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu peso?");
            double peso = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Qual sua altura em metros? (Utilize virgula para separar os numeros)");
            double altura = Convert.ToDouble(Console.ReadLine());


            double IMC = peso / Math.Pow(altura, 2);

            Console.WriteLine($"IMC: {IMC.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
