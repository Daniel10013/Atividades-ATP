﻿using System;

class Program{
    public static void Main(){
        int input, countPositive = 0, countNegative = 0, countZero = 0;
        char isToContinue;
        Console.WriteLine("Ativiade 3 - Exercício 1 \n");

        //entrada de dados
        input = GetInput();

        //procesamento de dados
        isToContinue = 'S';
        while(isToContinue != 'N'){
            if(input == 0){
                countZero++;
            }
            if(input > 0){
                countPositive ++;
            }
            if(input < 0){
                countNegative++;
            }
            
            Console.WriteLine("Deseja continuar? S / N");
            isToContinue = char.Parse(Console.ReadLine());
            isToContinue = isToContinueIsValid(isToContinue);

            if(isToContinue != 'N'){
                input = GetInput();
            }
        }
    
        //saida de dados
        Console.WriteLine("O número de valores positivos é: " + countPositive);
        Console.WriteLine("O número de valores negativos é: " + countNegative);
        Console.WriteLine("O número de zeros é: " + countZero);
    }

    public static char isToContinueIsValid(char isToContinue){
        if((isToContinue != 'S') && (isToContinue != 'N')){
            Console.WriteLine("Valor inválido digitado, digite  novamente: ");
            char input = char.Parse(Console.ReadLine());
            return isToContinueIsValid(input);
        }
        return isToContinue;
    }

    public static int GetInput(){
        bool inputIsValid;
        int input;

        Console.WriteLine("Digite um número inteiro: ");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while(inputIsValid == false){
            Console.WriteLine("Número inválido digitado, digite  novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

