namespace Exercises
{
    public class Exercise4: BaseExercise
    {
        public void Run()
        {
            int[] x = new int[10];
            int[] y = new int[10];
            GetValues(ref x, ref y);
            ShowNewArray(x, y);
        }

        public static void GetValues(ref int[] x, ref int[] y){
            Console.WriteLine("Digite os 10 valores de X:");
            for(int i = 0; i < 10; i++){
                x[i] = GetInput();
            }

            Console.WriteLine("Digite os 10 valores de Y:");
            for(int i = 0; i < 10; i++){
                y[i] = GetInput();
            }
        }

        public static void ShowNewArray(int[] x, int[] y){
            int[] newArray = new int[20];
            int positionX = 0, positionY = 0;

            for(int i = 0; i < 20; i++){
                if(i % 2 == 0 ){
                    newArray[i] = x[positionX];
                    positionX++;
                }
                else{
                    newArray[i] = y[positionY];
                    positionY++;
                }
            }

            Console.WriteLine("Veja os valores do vetor:");
            foreach(int item in newArray){
                Console.WriteLine(item);
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