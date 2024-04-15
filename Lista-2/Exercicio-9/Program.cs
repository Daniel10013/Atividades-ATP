using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 9 \n");

        string selectedOption;

        bool salaryIsValid;
        //entrada da dados
        Console.WriteLine("Selecione um simbolo: "); 
        selectedOption = Console.ReadLine();

        //processamento e saida dos dados 
        switch (selectedOption) {
            case "-": 
                Console.WriteLine("Sinal de menos!");
            break;

            case "+":
                Console.WriteLine("Sinal de mais!");
            break;

            case "=": 
                Console.WriteLine("Sinal de igual!");
            break;

            default: 
                Console.WriteLine("Outro sinal!");
            break;
        }
    }
}

