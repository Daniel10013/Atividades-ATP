namespace Exercises
{
    public class Exercise4: BaseExercise
    {
        public void Run()
        {
            string filePath = "./Files/exercise.txt";
            string fileContent;
            int charCount = 0;
            try
            {
                fileContent = File.ReadAllText(filePath);

                foreach(char c in fileContent){
                    if(c == 'a'|| c == 'A'){
                        charCount++;
                    }
                }

                Console.WriteLine("Quantidade de caracteres 'a' = " + charCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            }
        }
    }
}