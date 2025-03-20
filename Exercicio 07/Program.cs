namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota na primeira prova:");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Digite o peso da nota na primeira prova:");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite sua nota na segunda prova:");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Digite o peso da nota na segunda prova:");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
            Console.WriteLine(resultado);
            Console.ReadLine();


        }
    }
}
