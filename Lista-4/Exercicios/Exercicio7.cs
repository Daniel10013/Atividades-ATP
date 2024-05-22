namespace Exercises
{
    public class Exercise7: BaseExercise
    {
        public void Run()
        {
            GetConcept();   
        }

        public void GetConcept(){
            int finalGrade;        
            bool isToContinue = true;

            while(isToContinue != false){

                Console.WriteLine("Digite a nota final:");
                finalGrade = GetInput();
                if(finalGrade <= 39){
                    Console.WriteLine("F");
                }

                if(finalGrade >= 40 && finalGrade <= 59){
                    Console.WriteLine("E");
                }

                if(finalGrade >= 60 && finalGrade <= 69){
                    Console.WriteLine("D");
                }

                if(finalGrade >= 70 && finalGrade <= 79){
                    Console.WriteLine("C");
                }

                if(finalGrade >= 80 && finalGrade <= 89){
                    Console.WriteLine("B");
                }

                if(finalGrade >= 90){
                    Console.WriteLine("A");
                }

                Console.WriteLine("Deseja continuar? S | N");
                isToContinue = Console.ReadLine().ToLower() == "s" ? true : false;            
            }
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