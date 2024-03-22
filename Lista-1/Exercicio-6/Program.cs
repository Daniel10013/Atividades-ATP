using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 1 - Exercício 6\n");

        int numberA, numberB, aux;

        //entrada de dados
        Console.WriteLine("Digite o número A: ");
        numberA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        numberB = int.Parse(Console.ReadLine());

        //processamento de dados
        aux = numberA;
        numberA = numberB;
        numberB = aux;

        //saida de dados
        Console.WriteLine($"O valor do número A era: {numberB}\nA se tornou: {numberA}");
        Console.WriteLine($"O valor do número B era: {numberA}\nB se tornou: {numberB}");
    }
}

