using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 7 \n");
        
        int xValue;
        double yValue = 0;
        
        //entrada da dados
        Console.WriteLine("Insira o valor de X:");
        xValue = int.Parse(Console.ReadLine());

        //processamento dos dados 
        if(xValue <= 1){
            yValue = 1;
        }
        if(xValue > 1 && xValue <= 2){
            yValue = 2;
        }
        if(xValue > 2 && xValue <= 3){
            yValue = Math.Pow(xValue, 2);
        }
        if(xValue > 3){
            yValue = Math.Pow(xValue, 3);
        }

        //saida de dados
        Console.WriteLine("O valor de Y é: " + yValue);
    }
}

