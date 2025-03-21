namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numero1Maior = false, numero1SegundoMaior = false, numero1Menor = false;
            bool numero2Maior = false, numero2SegundoMaior = false, numero2Menor = false;
            bool numero3Maior = false, numero3SegundoMaior = false, numero3Menor = false;

            while (true)
            {

                Console.WriteLine("Escreva um numero inteiro");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva um numero inteiro");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva um numero inteiro");
                int numero3 = Convert.ToInt32(Console.ReadLine());

                if (numero1 > numero2 && numero1 > numero3)
                    numero1Maior = true;

                else if (numero1 < numero2 && numero1 < numero3)
                    numero1Menor = true;

                else
                    numero1SegundoMaior = true;



                if (numero2 > numero1 && numero2 > numero3)
                    numero2Maior = true;

                else if (numero2 < numero1 && numero2 < numero3)
                    numero2Menor = true;

                else 
                    numero2SegundoMaior = true;



                if (numero3 > numero2 && numero3 > numero1)
                    numero3Maior = true;

                else if (numero3 < numero1 && numero3 < numero2)
                    numero3Menor = true;

                else
                    numero3SegundoMaior = true;





                if (numero1Maior == true && numero2SegundoMaior == true && numero3Menor == true)
                {
                    Console.WriteLine($"{numero1} {numero2} {numero3}");
                    Console.ReadLine();
                }

                else if (numero2Maior == true && numero1SegundoMaior == true && numero3Menor == true)
                {
                    Console.WriteLine($"{numero2} {numero1} {numero3}");
                    Console.ReadLine();
                }

                else if (numero3Maior == true && numero2SegundoMaior == true && numero1Menor == true)
                {
                    Console.WriteLine($"{numero3} {numero2} {numero1}");
                    Console.ReadLine();
                }


                else if (numero1Maior == true && numero3SegundoMaior == true && numero2Menor == true)
                {
                    Console.WriteLine($"{numero1} {numero3} {numero2}");
                    Console.ReadLine();
                }


                else if (numero2Maior == true && numero3SegundoMaior == true && numero1Menor == true)
                {
                    Console.WriteLine($"{numero2} {numero3} {numero1}");
                    Console.ReadLine();
                }

                else if (numero3Maior == true && numero1SegundoMaior == true && numero2Menor == true)
                {
                    Console.WriteLine($"{numero3} {numero1} {numero2}");
                    Console.ReadLine();
                }
            }

        }
    }
}
