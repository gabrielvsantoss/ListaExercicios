namespace Exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementoAtual = 0;
            int proximoElemento = 1;

            Console.WriteLine("Sequencia de Finobacci");

            Console.WriteLine("Numero inteiro para mostrarmos a sequencia de fibonacci ate ele:");
            int numeroElementos = Convert.ToInt32(Console.ReadLine());


            for(int i = 2; i <= numeroElementos; i ++)
            {
                int soma = elementoAtual + proximoElemento;
                Console.WriteLine($"{elementoAtual} + {proximoElemento} = {soma}:");

                elementoAtual = proximoElemento;
                proximoElemento = soma;
            }

            Console.ReadLine();

        }
    }
}
