using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 9 \n");
        double buyValue, sellValue, profitPercent, totalProfit = 0, totalBuy = 0, totalSell = 0;
        int qnt10 = 0, qnt10and20 = 0, qnt20 = 0;

        do{
            buyValue = GetInput();
            if(buyValue == 0){
                break;
            }   
            totalBuy += buyValue;

            sellValue = GetInput(true);
            totalSell += sellValue;

            totalProfit += sellValue - sellValue;

            profitPercent = (buyValue / sellValue) * 100;
            if(profitPercent < 10){
                qnt10++;
            }
            if((profitPercent >= 10) && (profitPercent <= 20)){
                qnt10and20++;
            }
            if(profitPercent > 20){
                qnt20++;
            }

        }while(buyValue != 0);

        Console.WriteLine("A quantidade de mercadorias com lucro acima de 10% é: " + qnt10);
        Console.WriteLine("A quantidade de mercadorias com lucro entre 10% e 20% é: " + qnt10and20);
        Console.WriteLine("A quantidade de mercadorias com lucro acima de 20% é: " + qnt20);
        Console.WriteLine("O valor total de compra das mercadorias é de: {0:C2}", totalBuy);
        Console.WriteLine("O valor total de venda das mercadorias é de: {0:C2}", totalSell);
        Console.WriteLine("O valor total de lucro com as mercadorias é de: {0:C2}", totalProfit);
    }

    public static double GetInput(bool isSell = false)
    {
        bool inputIsValid;
        double input;

        string messageInput = "Insira o valor de compra: ";
        if(isSell == true){
            messageInput = "Insira o valor de venda: ";
        }

        Console.WriteLine(messageInput);
        inputIsValid = double.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Valor inválido digitado! Digite novamente:");
            inputIsValid = double.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

