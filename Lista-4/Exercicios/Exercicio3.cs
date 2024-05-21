namespace Exercises
{
    public class Exercise3: BaseExercise
    {
        public void Run()
        {
            int value1, value2, value3;
            int higher = int.MinValue, lower = int.MaxValue, mid = 0;
            bool isToContinue = true;

            while(isToContinue != false){
                
                Console.WriteLine("Digite o primeiro valor:");
                value1 = GetInput();
                
                Console.WriteLine("Digite o segundo valor:");
                value2 = GetInput();
                
                Console.WriteLine("Digite o terceiro valor:");
                value3 = GetInput();
                
                int[] values = [value1, value2, value3];
                foreach(int value in values){
                    if(value > higher){
                        higher = value;
                    }

                    if(value < higher && value < lower){
                        lower = value;
                    }
                }

                foreach(int value in values){
                    if(value > lower && value < higher){
                        mid = value;   
                    }
                }

                Console.WriteLine("Os valores ordenados na ordem crescente sao:");
                Console.WriteLine(lower);
                Console.WriteLine(mid);
                Console.WriteLine(higher);

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