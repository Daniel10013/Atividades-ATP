using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 3 \n");

        int aValue, bValue, result;

        // x = -b/a
        //entrada da dados
        Console.WriteLine("Insira o valor de A:");
        aValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor de B:");
        bValue = int.Parse(Console.ReadLine());

        if(aValue <= 0 || bValue <= 0){
            Console.WriteLine("Os valores para A e B não podem ser zero nem negativos!");
            return;
        }
        
        //processamento de dados
        result = -bValue / aValue;
        
        //saida de dados
        Console.WriteLine("O valor da raiz quadrada é: " + result);
    }
}

