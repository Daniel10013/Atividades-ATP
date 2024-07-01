namespace Exercises
{
    public class Exercise7: BaseExercise
    {
        public void Run()
        {
            char userInput, isToContinue = 'S';
            StreamWriter sw = new StreamWriter("./Files/exercicio7.txt");
            Console.WriteLine("Os divisores desse numero sao: ");
            
            while(char.ToUpper(isToContinue) != 'N'){
                userInput = GetInput();
                sw.Write(userInput);
                isToContinue = char.Parse(Console.ReadLine());
            }
            sw.Close();
            
            StreamReader sr = new StreamReader("./Files/exercicio7.txt");
            string fileLine = sr.ReadLine();
            int qntVogais = 0;
            while(fileLine != null){
                qntVogais += GetVowelsQnt(fileLine);
            }
            sr.Close();
            Console.WriteLine("A quantidade de vogais no arquivo eh de: " + qntVogais);
        }

        static int GetVowelsQnt(string line){
            int qnt = 0;
            string vowels = "aeiouAEIOU";

            foreach(char character in line){
                if(!vowels.Contains(character)){
                    qnt ++;
                }
            }
            return qnt;
        }

        public static char GetInput()
        {
            bool inputIsValid;
            char input;

            Console.WriteLine("Digite uma letra: ");
            inputIsValid = char.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input < 0)
            {
                Console.WriteLine("Letra inválida digitada, digite  novamente: ");
                inputIsValid = char.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}