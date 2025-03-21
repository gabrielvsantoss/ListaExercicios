namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Qual sua idade?");
            int idade = Convert.ToInt16(Console.ReadLine());

            int diasVividos = idade * 365;

            Console.WriteLine($"{nome} voce ja viveu {diasVividos} dias");
            Console.ReadLine();
        }
    }
}
