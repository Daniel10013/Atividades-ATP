using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 8 \n");
        int typedNumber, secondToLast = 0, lastNumber = 1, nextNumber;

        typedNumber = GetInput();
        Console.WriteLine("\n Os próximos " + typedNumber + " números da sequência de Fibonacci são: ");

        Console.WriteLine(secondToLast);
        Console.WriteLine(lastNumber);
        for(int i = 0; i < typedNumber - 2; i++){
            nextNumber = secondToLast + lastNumber;
            Console.WriteLine(nextNumber);
            secondToLast = lastNumber;
            lastNumber = nextNumber;
        }
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

