namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase = 0, comissao = 0, vendas = 0;

            Console.WriteLine("Qual seu salario base?");
            salarioBase = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Qual voce vendeu?");
            vendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem da sua comissão sobre as suas vendas?");
            decimal porcentagemComissao = Convert.ToDecimal(Console.ReadLine());

            comissao = vendas * (porcentagemComissao / 100);

            decimal salarioFinal = comissao + salarioBase;

            Console.WriteLine($"Seu salario final foi de: R${salarioFinal}");
            Console.ReadLine();
        }
    }
}
