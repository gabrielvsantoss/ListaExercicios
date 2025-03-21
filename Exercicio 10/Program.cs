namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantPao = 0, quantBroa = 0, valorVendido = 0;

            Console.WriteLine("Bem vindo a padaria HOTPAO");

               while (true)
            {
                Console.Clear();
                 Console.WriteLine("Qual foi sua venda? (P - Pão | B - Broa | S - Para finalizar o dia e visualizar os resultados)");
                 string venda = Console.ReadLine()!.ToUpper();

                if (venda == "P")
                if (venda == "P")
                    quantPao++;

                else if (venda == "B")
                    quantBroa++;

                else
                    break;
            }

            valorVendido = (quantPao * 0.12) + (quantBroa * 0.15);
            double poupanca = valorVendido * 0.10;

            Console.WriteLine($"A HotPao vendeu {quantPao} Pães hoje");
            Console.WriteLine($"A HotPao vendeu {quantBroa} Broas hoje");
            Console.WriteLine($"Isso gerou um faturamento de: R${valorVendido.ToString("F2")}");
            Console.WriteLine($"A HotPao deve por 10% disso na poupança e isso da aproximadamente: R${poupanca.ToString("F2")}");
            Console.ReadLine();

        }
    }
}
