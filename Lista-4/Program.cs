using System;
using Atividades;

class Program
{
    public static void Main()
    {
        int selectedExercise = GetInput();

        BaseExercise[] exercises = [
            new Atividade1(),
            new Atividade2(),
            new Atividade3(),
            new Atividade4(),
            new Atividade1(),
            new Atividade1(),
            new Atividade1(),
            new Atividade1(),
            new Atividade1(),
            new Atividade1()
        ];

        exercises[selectedExercise - 1].Run();

    }


    public static int GetInput()
    {
        bool inputIsValid;
        int input;

        Console.WriteLine("Digite o exercício selecionado: (1-10)");
        inputIsValid = int.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false || input > 10 || input < 1)
        {
            Console.WriteLine("Número inválido digitado, digite  novamente: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }

}