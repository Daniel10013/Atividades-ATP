namespace Exercises
{
    public class Exercise8: BaseExercise
    {
        public void Run()
        {
            double value;      
            
            Console.WriteLine("Digite um numero:");
            value = GetInput();

            Console.WriteLine("O valor de S e: {0:f3}", GetValue(value));
        }

        public static double GetValue(double nValue){
            double finalValue = 0;

            for(int i = 0; i < nValue; i++){
                finalValue += (Math.Pow(nValue, 2) + 1) / (nValue + 3);
            }

            return finalValue;
        }

        public static double GetInput()
        {
            bool inputIsValid;
            double input;

            inputIsValid = double.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = double.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}