namespace Exercises
{
    public class Exercise5: BaseExercise
    {
        public void Run()
        {   
            int value1, value2, mdcValue;

            Console.WriteLine("Digite o primeiro número:");
            value1 = GetInput();

            Console.WriteLine("Digite o primeiro número:");
            value2 = GetInput();

            mdcValue = GetMDC(value1, value2);
            Console.WriteLine("O valor do MDC é: " + mdcValue);
        }

        public static int GetMDC(int value1, int value2)
        {
            while (value2 != 0)
            {
                int temp = value2;
                value2 = value1 % value2;
                value1 = temp;
            }
            return value1;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input < 0)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}