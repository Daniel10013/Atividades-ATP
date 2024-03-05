using System;

class Program{
    public static void Main(){
        int figureBase, figureHeight, figurePerimeter, figureArea;
        double figureDiagonal;
        Console.WriteLine("Ativiade 1 - Exercício 1 \n");
        //entrada de dados
        Console.WriteLine("Digite o valor da base do retângulo:");
        figureBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do retângulo:");
        figureHeight = int.Parse(Console.ReadLine());

        //procesamento de dados
        figurePerimeter = (figureBase +  figureHeight) * 2;
        figureArea = figureBase * figureHeight;
        figureDiagonal = Math.Sqrt(Math.Pow(figureBase, 2) + Math.Pow(figureArea, 2));

        //saida de dados
        Console.WriteLine("O valor do perimetro do retângulo é: "+ figurePerimeter);
        Console.WriteLine("O valor da área do retângulo é: "+ figureArea);
        Console.WriteLine($"O valor da diagonal do retângulo é: {0:2F}", figureDiagonal);
    }
}

