namespace Exercises
{
    public class Exercise9 : BaseExercise
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Digite 1 para salvar dados ou 2 para inserir novos dados:");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Digite o numero do estudante:");
                    string registration = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do estudante:");
                    string phone = Console.ReadLine();

                    using (StreamWriter sw = new StreamWriter("students.txt", true))
                    {
                        sw.WriteLine($"{registration},{phone}");
                    }
                }
                else if (option == "2")
                {
                    using (StreamReader sr = new StreamReader("students.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split(',');
                            Console.WriteLine($"Registration: {data[0]}, Phone: {data[1]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opcao invalida!");
                }
            }
        }
    }
}