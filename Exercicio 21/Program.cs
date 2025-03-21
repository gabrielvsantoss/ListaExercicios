
namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            Console.WriteLine("Digite um numero inteiro");
            int numero = Convert.ToInt32(Console.ReadLine());


            for (int a = 0; a < numero; a++)
            {
             


                Console.WriteLine($"{numero} X {a}");  

                resultado = numero * a;
            }
            Console.ReadLine();

        }
    }
}
