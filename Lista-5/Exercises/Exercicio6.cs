namespace Exercises
{
    public class Exercise6: BaseExercise
    {
        public void Run()
        {   
            double[] temperaturas = new double[31];

            Random rand = new Random();
            for (int i = 0; i < 31; i++)
            {
                temperaturas[i] = rand.Next(15, 41);
            }

            double menorTemperatura = temperaturas.Min();
            double maiorTemperatura = temperaturas.Max();
            double temperaturaMedia = temperaturas.Average();
            int diasAbaixoMedia = temperaturas.Count(t => t < temperaturaMedia);

            Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
            Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");
            Console.WriteLine($"Temperatura média: {temperaturaMedia:F2}°C");
            Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoMedia}");

            Console.WriteLine("\nTemperaturas diárias:");
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine($"Dia {i + 1}: {temperaturas[i]}°C");
            }
        }
    }
}