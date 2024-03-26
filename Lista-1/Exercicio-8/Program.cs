using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 1 - Exercício 8 \n");

        string currentAccountString, inversed; 
        char[] numbers;
        int currentAccount, inverseAccountNumber, sum;
        int mil, cent, deze, un, finalSum, verificador;

        //entrada de dados
        Console.WriteLine("Digite o valor da conta corrente: ");
        currentAccountString = Console.ReadLine();
        numbers = currentAccountString.ToCharArray();
        inversed = $"{numbers[2]}{numbers[1]}{numbers[0]}";

        currentAccount = int.Parse(currentAccountString);
        inverseAccountNumber = int.Parse(inversed);

        sum = currentAccount + inverseAccountNumber;

        mil = sum / 1000;
        cent = (sum / 1000) % 100;
        deze = (sum / 1000) % 10;
        un = (sum / 1000) % 10;

        finalSum = (mil * 0) + (cent * 1) + (deze * 2) + (un * 3);
        verificador = finalSum % 10;
        //saida de dados
        Console.WriteLine("A soma final é: " + finalSum);
        Console.WriteLine("O digito verificador é: " + verificador);
    }
}

