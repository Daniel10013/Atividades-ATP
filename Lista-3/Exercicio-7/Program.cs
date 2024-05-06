using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 7 \n");
        double typedNumber;
        double sValue = 1;
        
        typedNumber = GetInput();

        for(double i = typedNumber; i > 1; i--){
            sValue += 1 / i;
        }

        Console.WriteLine("O valor de S é: {0:f4}", sValue);

    }

    public static double GetInput()
    {
        bool inputIsValid;
        double input;

        Console.WriteLine("Digite um número inteiro: ");
        inputIsValid = double.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Número inválido digitado, digite novamente: ");
            inputIsValid = double.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

