using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 2 - Exercício 8 \n");

        string selectedOption;
        double salary = 0, salaryNewValue = 0;

        bool salaryIsValid;
        //entrada da dados
        Console.WriteLine("Insira o valor do salário: ");
        salaryIsValid = double.TryParse(Console.ReadLine(), out salary);

        if(salaryIsValid == false){
            Console.WriteLine("Insira um valor válido para o salário!");
            return;
        }
        Console.WriteLine("Selecione o tipo de aumento: (A, B, C)"); 
        selectedOption = Console.ReadLine();

        //processamento e saida dos dados 
        switch (selectedOption) {
            case "A": 
                salaryNewValue = salary + (salary * 0.08);
                Console.WriteLine("O valor do salário com 8% de aumento é: {0:f2}", salaryNewValue);
            break;

            case "B": 
                salaryNewValue = salary + (salary * 0.11);
                Console.WriteLine("O valor do salário com 11% de aumento é: {0:f2}", salaryNewValue);
            break;

            case "C": 
                double valueToIncrease = 0;
                if(salary <= 1000){
                    valueToIncrease = 350;
                }
                if(salary > 1000){
                    valueToIncrease = 200;
                }
                salaryNewValue = salary + valueToIncrease;
                Console.WriteLine("O valor do salário com "+ valueToIncrease +" reais de aumento é: {0:f2}", salaryNewValue);
            break;

            default: 
                Console.WriteLine("Selecione uma opção válida!");
            break;
        }
    }
}

