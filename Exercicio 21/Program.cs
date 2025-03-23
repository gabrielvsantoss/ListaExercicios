

public class Exercicio21
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro:");
        int numero = Convert.ToInt32(Console.ReadLine());


        int fatorial = 1;

        for (int i = numero; i >= 1; i--)
        {
            fatorial *= i;

        }

        Console.WriteLine($"{numero}! = {fatorial}");
        Console.ReadLine();
    }
}