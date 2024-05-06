using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 9 \n");
        int typedNumber, secondToLast = 0, lastNumber = 1, nextNumber, numbersSum = 0;

        typedNumber = GetInput();

        for(int i = 0; i < typedNumber; i++){
            nextNumber = secondToLast + lastNumber;
            numbersSum += nextNumber;
            secondToLast = lastNumber;
            lastNumber = nextNumber;
        }

        Console.WriteLine("A soma dos números de Fibonacci é: " + numbersSum);
    }

    public static int GetInput()
    {
        bool inputIsValid;
        int input;

        Console.WriteLine("Digite um número inteiro: ");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Número inválido digitado, digite novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

