using System;

class Program{
    public static void Main(){
        int input, countPositive = 0, countNegative = 0, countZero = 0, countTotal = 0;
        double percentNegative, percentPositive, percentZero;
        char isToContinue;
        Console.WriteLine("Ativiade 3 - Exercício 2 \n");

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

            countTotal++;
            
            Console.WriteLine("Deseja continuar? S / N");
            isToContinue = char.Parse(Console.ReadLine());
            isToContinue = isToContinueIsValid(isToContinue);

            if(isToContinue != 'N'){
                input = GetInput();
            }
        }

        percentPositive = countPositive != 0 ? (countPositive / countTotal) * 100 : 0;
        Console.WriteLine((countPositive / countTotal) * 100);
        percentNegative = countNegative != 0 ? (countNegative / countTotal) * 100 : 0;
        Console.WriteLine((countNegative / countTotal) * 100);
        percentZero = countZero != 0 ? (countZero / countTotal) * 100 : 0;
    
        //saida de dados
        Console.WriteLine("O percentual de valores positivos é: " + percentPositive);
        Console.WriteLine("O percentual valores negativos é: " + percentNegative);
        Console.WriteLine("O percentual zeros é: " + percentZero);
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

