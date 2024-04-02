using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 1 \n");

        int firstNumber, secondNumber, numberToPrint;
        
        //entrada da dados
        Console.WriteLine("Insira o valor do primeiro número:");
        firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira o valor do segundo número:");
        secondNumber = int.Parse(Console.ReadLine());
 
        //processamento 
        numberToPrint = (firstNumber > secondNumber) ? firstNumber : secondNumber;
        
        //saida de dados
        Console.WriteLine("O maior número é: " + numberToPrint);
    }
}

