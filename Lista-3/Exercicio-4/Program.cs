using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 4 \n");
        int typedNumber, fatorial = 1;

        typedNumber = GetInput();
        for(int i = typedNumber; i > 1; i--){
            fatorial *= i;
        }
        
        Console.WriteLine("O fatorial de " + typedNumber + " é: " + fatorial);
    }

    public static int GetInput()
    {
        bool inputIsValid;
        int input;

        Console.WriteLine("Digite um número inteiro: ");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false || input < 0)
        {
            Console.WriteLine("Número inválido digitado, digite  novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

