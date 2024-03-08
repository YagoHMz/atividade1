using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Double[] salario = new Double[10];
        Double maior = -1;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite o " + (i + 1) + "° salário: ");
            Double.TryParse(Console.ReadLine(), out salario[i]);
        }



        for (int i = 0; i < 10; i++)
        {
            if (salario[i] > maior)
            {
                maior = salario[i];
            }
        }

        Console.WriteLine("O Maior salario é o com R$" + maior);
    }
}

