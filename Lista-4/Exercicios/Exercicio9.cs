namespace Exercises
{
    public class Exercise9: BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("O valor da media de notas acima de 6 e:" + GetMedia());
        }

        public int GetMedia(){
            int grade, sumGrades = 0, qntGrades = 0;        
            bool isToContinue = true;

            while(isToContinue != false){

                Console.WriteLine("Digite a nota:");
                grade = GetInput();

                if(grade >= 6){
                    sumGrades += grade;
                    qntGrades++;
                }

                Console.WriteLine("Deseja continuar? S | N");
                isToContinue = Console.ReadLine().ToLower() == "s" ? true : false;            
            }

            return sumGrades / qntGrades;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false && input > 0)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}