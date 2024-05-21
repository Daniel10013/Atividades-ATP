using System;

namespace Exercises
{
    public class Exercise2: BaseExercise
    {
        public void Run()
        {
            int salary, totalSalary = 0, qntOfChilds, totalChilds = 0, qntPeople = 0, salaryMedia, qntdOfChildsMedia; 
            bool isToContinue = true;

            while(isToContinue != false){
                Console.WriteLine("Digite o valor do salario:");
                salary = GetInput();
                totalSalary += salary;

                Console.WriteLine("Digite a quantidade de filhos:");
                qntOfChilds = GetInput();
                totalChilds += qntOfChilds;
                
                qntPeople++;

                Console.WriteLine("Deseja continuar? S | N");
                isToContinue = Console.ReadLine().ToLower() == "s" ? true : false;
            }

            salaryMedia = totalSalary / qntPeople;
            qntdOfChildsMedia = totalChilds / qntPeople;

            Console.WriteLine("A media de salario e: " + salaryMedia);
            Console.WriteLine("A media de quantidade de filhos e: " + qntdOfChildsMedia);

        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}