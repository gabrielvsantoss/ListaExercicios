namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numero = 0;
                bool numeroEhPrimo = true;
                Console.WriteLine("Digite um numero");
                numero = Convert.ToInt32(Console.ReadLine());
                
                if (numero < 2)
                    numeroEhPrimo = false;

                else if (numero == 2)
                    numeroEhPrimo = true;

                else if (numero % 2 == 0)
                    numeroEhPrimo = false;

                for(int i  = 3; i * i <= numero; i+= 2)
                {
                    if(numero % i == 0)
                    {
                        numeroEhPrimo = false;
                    }
                }

                if (numeroEhPrimo == false)
                    {
                        Console.WriteLine("O numero não é primo");
                        Console.ReadLine();
                    }

                else
                {
                    Console.WriteLine("O numero é primo");
                    Console.ReadLine();
                }
                

            }

        }
    }
}
