namespace Exercises
{
    public class Exercise5: BaseExercise
    {
        public void Run()
        {  
            bool correct = false;
            int[] numbers = GetRandomNumbers();
            int guess;

            while(correct == false){
                Console.WriteLine("Tente adivinhar o numero aleatorio entre 10 e 50");
                guess = GetInput();
                foreach(int value in numbers){
                    if(guess == value){
                        correct = true;
                    }
                }
                
                if(correct == true){
                    Console.WriteLine("Parabens voce acertou!");
                }else{
                    Console.WriteLine("Numero incorreto!");    
                }
            }
        }

        public static int[] GetRandomNumbers(){
            int[] numbers = new int[3];
            Random rnd = new Random();
            for(int i = 0; i < 3; i++){
                numbers[i] = rnd.Next(10, 51);
            }

            return numbers;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite  novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}