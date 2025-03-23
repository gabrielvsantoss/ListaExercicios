namespace Exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            for (int a =  1; a <= 10; a++)
            {
               

                resultado = numero * a;
                Console.WriteLine($"{numero} x {a} = {resultado}");
            }

            Console.ReadLine();
        }
    }
}
