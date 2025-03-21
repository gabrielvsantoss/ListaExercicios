namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Escreva um numero inteiro");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva um numero inteiro");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva um numero inteiro");
                int numero3 = Convert.ToInt32(Console.ReadLine());

                int[] numeros = [numero1, numero2, numero3];

                Array.Sort(numeros);

                Array.Reverse(numeros);

                for(int i = 0; i < numeros.Length; i ++)
                {
                    Console.WriteLine(numeros[i]);
                }

                Console.ReadLine();
            }

        }
    }
}
