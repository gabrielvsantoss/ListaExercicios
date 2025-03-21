namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = 0;

            if (A == B)
                C = A + B;

            else
                C = A * B;

            Console.WriteLine($"O valor de C é {C}");
            Console.ReadLine();
        }
    }
}
