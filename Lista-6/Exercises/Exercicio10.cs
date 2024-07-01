namespace Exercises
{
    public class Exercise10 : BaseExercise
    {
        public void Run()
        {
            string filePath = "./Files/numbers.txt";
            var numbers = File.ReadAllLines(filePath).Select(float.Parse).ToList();

            float max = numbers.Max();
            float min = numbers.Min();
            float average = numbers.Average();

            Console.WriteLine($"Valor maximo: {max}");
            Console.WriteLine($"Valor minimo: {min}");
            Console.WriteLine($"Valor medio: {average}");
        }
    }
}