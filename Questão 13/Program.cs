namespace Questão_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A soma de A + B é menor que C");
                Console.ReadLine();
            }

            else if (A + B > C)
            {
                Console.WriteLine("A soma de A + B é maior que C");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("A soma de A + B é igual que C");
                Console.ReadLine();
            }
        }
    }
}
