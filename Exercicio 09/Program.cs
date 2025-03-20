namespace Exercicio_09
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("             COMPRIMENTO    ");
            Console.WriteLine("          -----------------");
            Console.WriteLine("         |                 |");
            Console.WriteLine(" LARGURA |                 |");
            Console.WriteLine("         |                 |");
            Console.WriteLine("          -----------------");


            Console.WriteLine("Digite a largura do terreno");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o comprimento  do terreno");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            int area = largura * comprimento;

            Console.WriteLine($"Area do terreno : {area}");
            Console.ReadLine();


        }
    }
}
