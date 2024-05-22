using System;
using Exercises;

class Program
{ 
    public static void Main()
    {
        int selectedExercise = GetInput();

        BaseExercise[] exercises = [
            new Exercise1(),
            new Exercise2(),
            new Exercise3(),
            new Exercise4(),
            new Exercise5(),
            new Exercise6(),
            new Exercise7(),
            new Exercise8(),
            new Exercise9(),
            new Exercise10()
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