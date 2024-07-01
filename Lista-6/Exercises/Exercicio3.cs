namespace Exercises
{
    public class Exercise3: BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("Digite uma frase:");
            string userInput = Console.ReadLine();
            string result = "";

            int i;
            foreach(char c in userInput){
                char toAdd = c;
                if(char.IsLetter(c) == true){
                    i = (int)c + 3;
                    toAdd = (char)i;
                }
                result += toAdd;
            }

            Console.WriteLine("A frase criptografada eh: ");
            Console.WriteLine(result);
        }
    }
}