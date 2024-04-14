using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 6 \n");
        
        int availableRooms = 75;
        double dailyValue, promotionalDailyValue;
        double totalGainsWith80PercentOcupationAndPromotion, totalGainsWith50PercentOcupationAndNoPromotion;
        double differenceBetweenGains;

        //entrada da dados
        Console.WriteLine("Insira o valor do preço da diária do hotel:");
        dailyValue = double.Parse(Console.ReadLine());

        //processamento dos dados
        promotionalDailyValue = dailyValue - (dailyValue * 0.25);
        totalGainsWith80PercentOcupationAndPromotion = (availableRooms * 0.8) * promotionalDailyValue;
        totalGainsWith50PercentOcupationAndNoPromotion = (availableRooms * 0.5) * dailyValue;

        if(totalGainsWith50PercentOcupationAndNoPromotion > totalGainsWith80PercentOcupationAndPromotion){
            differenceBetweenGains = totalGainsWith50PercentOcupationAndNoPromotion - totalGainsWith80PercentOcupationAndPromotion;
        }else{
            differenceBetweenGains = totalGainsWith80PercentOcupationAndPromotion - totalGainsWith50PercentOcupationAndNoPromotion;
        }

        //saida de dados
        Console.WriteLine("O valor da diária com desconto é: " + promotionalDailyValue);
        Console.WriteLine("O valor arrecadado com 80% dos quartos ocupados e com o valor da diária com desconto foi: " + totalGainsWith80PercentOcupationAndPromotion);
        Console.WriteLine("O valor arrecadado com 50% dos quartos ocupados e com o valor da diária sem desconto foi: " + totalGainsWith50PercentOcupationAndNoPromotion);
        Console.WriteLine("O valor da diferença dos ganhos das vendas foi: " + differenceBetweenGains);
    }
}

