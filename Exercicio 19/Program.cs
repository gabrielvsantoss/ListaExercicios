
namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
           
            for(int i = 1; i < 500; i+= 2)
            {
                 if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
