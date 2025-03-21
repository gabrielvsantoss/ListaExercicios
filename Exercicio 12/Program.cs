namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salario base");
            double salarioBase = Convert.ToInt32(Console.ReadLine());

            double salarioAumento = salarioBase + (salarioBase * 0.15);
            double impostos = salarioAumento * 0.08;
            double salarioFinal = salarioAumento - impostos;

            Console.WriteLine($"Seu salario base é de R${salarioBase.ToString("F2")}");
            Console.WriteLine($"Seu salario com o aumento ficou: R${salarioAumento.ToString("F2")}");
            Console.WriteLine($"Seus impostos ficaram no valor de: R${impostos.ToString("F2")}");
            Console.WriteLine($"Seu salario final é de: R${salarioFinal.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
