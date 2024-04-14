using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 4 \n");

        int currentYear = 2024;
        int birthYear, age;
        char havePassedBirthday;
        string message, licenseMessage;

        //entrada da dados
        Console.WriteLine("Insira sua data de nascimento:");
        birthYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu aniversário desse ano já passou?\nS(Sim) / N(Não)");
        havePassedBirthday = char.Parse(Console.ReadLine());

        //processamento dos dados
        if(havePassedBirthday != 'S' && havePassedBirthday != 'N'){
            Console.WriteLine("A escolha do aniversário só pode ser S(Sim) / N(Não)!");
            return;
        }

        age  = currentYear - birthYear;
        if(havePassedBirthday == 'N'){
            age--;
        }
        message = "Sua idade é: " + age;

        licenseMessage = "Você não possui idade para tirar carteira de motorista!";
        if(age >= 18){
            licenseMessage = "Você já possui idade para tirar carteira de motorista!";
        }

        //saida de dados
        Console.WriteLine(message + "\n" + licenseMessage);
    }
}

