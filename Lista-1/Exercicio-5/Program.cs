using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 1 - Exercício 5\n");

        int monthsQuantity;
        double taxByMonth, finalAmount, monthlyApplication;

        //entrada de dados
        Console.WriteLine("Digite o valor da aplicação mensal: ");
        monthlyApplication = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da taxa mensal: ");
        taxByMonth = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a quantidade de mêses que o dinheiro ficara na poupança: ");
        monthsQuantity = int.Parse(Console.ReadLine());
        
        //processamento de dados
        double taxPow = Math.Pow((1 + taxByMonth), monthsQuantity);
        finalAmount = monthlyApplication * (taxPow - 1) / taxByMonth;

        //saida de dados
        Console.WriteLine("O valor final do rendimento é de: {0:C}", finalAmount);
    }
}

