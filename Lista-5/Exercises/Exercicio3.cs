namespace Exercises
{
    public class Exercise3: BaseExercise
    {
        public void Run()
        {
            int[] values = new int[10];
            GetValues(ref values);
            PrintNegatives(GetNegativeValues(values));
        }

        public static void GetValues(ref int[] values){
            Console.WriteLine("Digite os 10 valores:");
            for(int i = 0; i < 10; i++){
                values[i] = GetInput();
            }
        }

        public static int[] GetNegativeValues(int[] values){
            int qntNegative = 0;
            foreach(int value in values){
                if(value < 0){
                    qntNegative++;
                }
            }

            int[] negatives = new int[qntNegative];
            int position = 0;
            foreach(int value in values){
                if(value < 0){
                    negatives[position] = value;
                    position++;
                }
            }
            
            return negatives;
        }

        public static void PrintNegatives(int[] values){

            Console.WriteLine("Confira abaixo os valores negativos: ");
            foreach(int value in values){
                Console.WriteLine(value);
            }
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