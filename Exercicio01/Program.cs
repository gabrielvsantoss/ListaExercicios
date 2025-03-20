namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal comprimento, largura, altura;
            Console.WriteLine("Digite o comprimento da caixa em cm");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o largura da caixa em cm");
             largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o altura da caixa em cm");
            altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;

            Console.WriteLine($"o volume da caixa é de {resultado} cm³");
        }
    }
}
