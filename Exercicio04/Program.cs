namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Digite a temperatura em graus Celsius");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"A temperatura em fahrenheit é {fahrenheit}°F");
            Console.ReadLine();
        }

    }
}
