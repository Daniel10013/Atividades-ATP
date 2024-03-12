using System;

class Program
{
    public static void Main()
    {
        int kwVal, kwQnt, valDesc, minimumSalary = 1420;
    
        Console.WriteLine("Ativiade 1 - Exercício 3 \n");
        //entrada de dados
        Console.WriteLine("Insira o valor do salário mínimo:");
        minimumSalary = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a quantidade de Kilowatts:");
        kwQnt = int.Parse(Console.ReadLine());

        //processamento de dados
        kwVal = (minimumSalary / 7) / 100;
        valDesc = kwVal * kwQnt - (kwVal * kwQnt * 10 / 100);

        //saida de dados
        Console.WriteLine("O valor do kilowatt é: " + kwVal + "\n");
        Console.WriteLine("O valor a ser pago total é: " + kwVal * kwQnt + "\n");
        Console.WriteLine("O valor a ser pago com desconto é: " + valDesc);
    }
}

