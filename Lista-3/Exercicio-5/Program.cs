using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 5 \n");
        int typedNumber, fatorialI;
        double eValue = 1.0;

        typedNumber = GetInput();

        for(int i = 1; i <= typedNumber; i++){
            fatorialI = GetFatorial(i);
            eValue += 1.0 / fatorialI;
        }
        
        Console.WriteLine("O valor de E é: " + eValue);
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

    public static int GetFatorial(int number){        
        if(number != 0){
            return number * GetFatorial(number - 1);
        }
        return 1;
    }
}

