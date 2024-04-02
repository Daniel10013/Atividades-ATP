using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 2 \n");

        int firstNumber, secondNumber, finalResult;
        
        //entrada da dados
        Console.WriteLine("Insira o valor do primeiro número:");
        firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira o valor do segundo número:");
        secondNumber = int.Parse(Console.ReadLine());
 
        //processamento 
        int numberSum = firstNumber + secondNumber;
        finalResult = (numberSum >= 10) ? (numberSum + 5) : (numberSum + 7);
        
        //saida de dados
        Console.WriteLine("O resultado final é: " + finalResult);
    }
}

