namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial = 0, kmFinal = 0, consumoCombustivel = 0;


            Console.WriteLine("Km inicial:");
            kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Km inicial:");
            kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Consumo combustivel: ");
            consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;

            double combustivelGastoPorKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"Combustivel gasto por km foi de: {combustivelGastoPorKm}");
            Console.ReadLine();
        }
    }
}
