using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 3 \n");

        int typedNumber, divisibleBy9and3 = 0, divisibleBy2 = 0, divisibleBy5 = 0;
        bool isDivisibleByAny;

        for (int i = 0; i < 10; i++)
        {
            typedNumber = GetInput(i);

            isDivisibleByAny = false;
            if(IsDivisibleBy2(typedNumber) == true){
                divisibleBy2++;
                isDivisibleByAny = true;
            }

            if(IsDivisibleBy5(typedNumber) == true){
                divisibleBy5++;
                isDivisibleByAny = true;
            }

            if(IsDivisibleBy3and9(typedNumber) == true){
                divisibleBy9and3++;
                isDivisibleByAny = true;
            }

            if(isDivisibleByAny == false){
                Console.WriteLine("O número não é divisivel pelos valores: 2, 3, 5 e 9");
            }
        }

        Console.WriteLine("Quantidade de números divisiveis por 2: " + divisibleBy2);
        Console.WriteLine("Quantidade de números divisiveis por 5: " + divisibleBy5);
        Console.WriteLine("Quantidade de números divisiveis por 3 e 9: " + divisibleBy9and3);
    }

    public static int GetInput(int index)
    {
        bool inputIsValid;
        int input;

        Console.WriteLine(index + 1 + "- Digite um número inteiro: ");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Número inválido digitado, digite  novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }

    public static bool IsDivisibleBy3and9(int typedNumber)
    {
        string numberString = typedNumber.ToString();
        char[] typedNumbers = numberString.ToCharArray();

        int numbersSum = 0;
        foreach(char number in typedNumbers){
            numbersSum += (int)char.GetNumericValue(number);
        }
        
        if(numbersSum % 3 == 0 && numbersSum % 9 == 0){
            return true;
        }
        return false;
    }

    public static bool IsDivisibleBy5(int number)
    {
        return number % 5 == 0;
    }

    public static bool IsDivisibleBy2(int number)
    {
        return number % 2 == 0;
    }
}

