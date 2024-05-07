using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 11 \n");

        int typedNumber, total1 = 0, total2 = 0, total3 = 0, total4 = 0, nullVote = 0, whiteVote = 0;

        Menu();
        do{
            typedNumber = GetInput();
            if(typedNumber == 1){
                total1++;
            }
            if(typedNumber == 2){
                total2++;
            }
            if(typedNumber == 3){
                total3++;
            }
            if(typedNumber == 4){
                total4++;
            }
            if(typedNumber == 5){
                nullVote++;
            }
            if(typedNumber == 6){
                whiteVote++;
            }
        }while(typedNumber != 0);
        Console.WriteLine("O total de votos ficou:");
        Console.WriteLine($"Candidato 1: {total1}\nCandidato 2: {total2}\nCandidato 3: {total3}");
        Console.WriteLine($"Candidato 4: {total4}\nVotos nulos: {nullVote}\nVotos em branco: {whiteVote}");
    }

    public static int GetInput()
    {
        bool inputIsValid;
        int input;

        Console.WriteLine("Digite um número inteiro: ");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Número inválido digitado, digite  novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }

    public static void Menu(){
        Console.WriteLine("Digite o número do seu cadidato para votar: ");
        Console.WriteLine("1 - Candidato 1");
        Console.WriteLine("2 - Candidato 2");
        Console.WriteLine("3 - Candidato 3");
        Console.WriteLine("4 - Candidato 4");
        Console.WriteLine("5 - Voto nulo");
        Console.WriteLine("6 - Voto branco");
    }
}

