using System;

class Program{
    public static void Main(){
        int cateto1, cateto2;
        double hipotenusa;

        Console.WriteLine("Ativiade 1 - Exercício 2 \n");
        // entrada de dados
        Console.WriteLine("Digite o valor do primeiro cateto: ");
        cateto1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo cateto: ");
        cateto2 = int.Parse(Console.ReadLine());

        //processamento de dados
        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        //saida de dados
        Console.WriteLine("O valor da hipotenusa é: {0:f2}", hipotenusa);
    }
}

