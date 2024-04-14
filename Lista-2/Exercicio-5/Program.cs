using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 5 \n");

        int userNote;

        //entrada da dados
        Console.WriteLine("Insira uma nota de 0 a 10:");
        userNote = int.Parse(Console.ReadLine());

        //processamento dos dados
        //saida de dados
        if(userNote < 0 || userNote > 10){
            Console.WriteLine("Nota Inválida! Insira uma nota válida por favor!");
            return;
        }

        if(userNote < 5){
            Console.WriteLine("Sua nota é Insatisfatória!");
            return;
        }

        if(userNote >= 5 && userNote < 7){
            Console.WriteLine("Sua nota é Regular!");
            return;
        }

        if(userNote >= 7 && userNote < 8){
            Console.WriteLine("Sua nota é Boa!");
            return;
        }
        
        if(userNote >= 8 && userNote < 10){
            Console.WriteLine("Sua nota é Ótima!");
        }
    }
}

