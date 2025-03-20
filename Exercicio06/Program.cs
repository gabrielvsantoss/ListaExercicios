namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)

        {
            decimal quantidade = 0;
            while (true)
            {
                Console.WriteLine("Digite sua nota");
                decimal nota = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite sua nota");
                decimal nota2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite sua nota");
                decimal nota3 = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 3 / ((1 / nota) + (1 / nota2) + (1/ nota3));


                Console.WriteLine($"Media Harmonica: {resultado}");
                Console.ReadLine();
            }
        }
    }

}
