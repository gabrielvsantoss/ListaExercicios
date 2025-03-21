namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite um numero");
                int numero = Convert.ToInt32(Console.ReadLine());

                bool par = false, impar = false;

                if (numero % 2 == 0)
                    par = true;

                else
                    impar = true;


                if (par == true)
                {
                    Console.WriteLine($"O numero {numero} é par");
                    Console.ReadLine();
                }

                else 
                {
                    Console.WriteLine($"O numero {numero} é impar");
                    Console.ReadLine();
                }
            }
        }
    }
}
