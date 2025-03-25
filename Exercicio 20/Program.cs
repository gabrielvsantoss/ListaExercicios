namespace Exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            Console.Write($"{numero}! = {numero}");
            for (int i = numero; i >= 1; i --)
            {
                resultado *= i;


                if (i >= 1 && i != numero)
                {
                    Console.Write($" * {i}");
                }


            }
            
            Console.Write($" = {resultado}");
            Console.ReadLine();
        }
    }
}
