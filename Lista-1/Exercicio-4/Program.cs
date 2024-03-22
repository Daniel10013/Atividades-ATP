using System;

class Program
{
    public static void Main()
    {
        int x1, x2, y1, y2;
        double distance, xPow, yPow;
        Console.WriteLine("Ativiade 1 - Exercício 4 \n");
        //entrada de dados
        Console.WriteLine("Digite o ponto 1 do eixo X: ");
        x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ponto 2 do eixo X: ");
        x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ponto 1 do eixo Y: ");
        y1 = int.Parse(Console.ReadLine());        
        Console.WriteLine("Digite o ponto 2 do eixo Y: ");
        y2 = int.Parse(Console.ReadLine());

        //processamento de dados
        xPow = Math.Pow((x2 - x1), 2);
        yPow = Math.Pow((y2 - y1), 2);
        distance = Math.Sqrt(xPow + yPow);

        //saida de dados
        Console.WriteLine("O resultado da distância é: {0:f2}", distance);
    }
}

