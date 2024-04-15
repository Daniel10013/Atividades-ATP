using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 10 \n");

        int allowedSpeed = 0, driverSpeed = 0, penaltyValue, differenceBetweenSpeeds;
        bool allowedSpeedIsValid, driverSpeedIsValid;

        //entrada da dados
        Console.WriteLine("Insira o limite de velocidade: ");
        allowedSpeedIsValid = int.TryParse(Console.ReadLine(), out allowedSpeed);
        
        if(allowedSpeedIsValid == false){
            Console.WriteLine("Insira um valor válido para o limite de velocidade!");
            return;
        }

        Console.WriteLine("Insira a velocidade do motorista: ");
        driverSpeedIsValid = int.TryParse(Console.ReadLine(), out driverSpeed);
        
        if(driverSpeedIsValid == false){
            Console.WriteLine("Insira um valor válido para a velocidade do motorista!");
            return;
        }

        //processamento e saida dos dados
        differenceBetweenSpeeds = driverSpeed - allowedSpeed; 
        if(differenceBetweenSpeeds > 1 && differenceBetweenSpeeds <= 10){
            Console.WriteLine("Você foi multado em 50 reais por ultrapassar o limite de velocidade!");
            return;
        }

        if(differenceBetweenSpeeds > 11 && differenceBetweenSpeeds <= 30){
            Console.WriteLine("Você foi multado em 100 reais por ultrapassar o limite de velocidade!");
            return;
        }

        if(differenceBetweenSpeeds > 30){
            Console.WriteLine("Você foi multado em 200 reais por ultrapassar o limite de velocidade!");
            return;
        }

        Console.WriteLine("Motorista respeitou a lei!");
    }
}

