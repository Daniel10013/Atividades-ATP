using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 3 - Exercício 6 \n");

        double typedSalary, salaryMedia, sumSalaries, totalSalary = 0, highestSalary = 0, percentHigherThan100, childsMedia, totalHigherThan100 = 0;
        double qntSalary = 0, qntChilds = 0, childInput;
        double totalChild = 0;

        bool isToContinue = true;
        while(isToContinue == true){
            typedSalary = GetInput(false);
            if(typedSalary < 0){
                isToContinue = false;
                return;
            }
            childInput = GetInput(true);

            totalChild += childInput;
            totalSalary += typedSalary;
            qntSalary++;
            qntChilds++;

            if(typedSalary > highestSalary){
                highestSalary = typedSalary;
            }

            if(typedSalary > 100){
                totalHigherThan100 ++;
            }
        }

        salaryMedia = totalSalary / qntSalary;
        childsMedia = totalChild / qntChilds;
        percentHigherThan100 = (totalHigherThan100 / qntSalary) * 100;

        Console.WriteLine("Média de salários: {0:F2}", salaryMedia);
        Console.WriteLine("Média de número de filhos: {0:F2}", childsMedia);
        Console.WriteLine("Porcentagem de salários maiores que 100 em relação ao total: {0:F2}", percentHigherThan100);
        Console.WriteLine("Maior salário: {0:F2}", highestSalary);
    }

    public static double GetInput(bool child = false)
    {
        bool inputIsValid;
        double input;

        if(child == true){
            Console.WriteLine("Digite o número de filhos: ");
        }
        if(child == false){
            Console.WriteLine("Digite o valor do salário: ");
        }
        inputIsValid = double.TryParse(Console.ReadLine(), out input);

        while (inputIsValid == false)
        {
            Console.WriteLine("Número inválido digitado, digite novamente: ");
            inputIsValid = double.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}

