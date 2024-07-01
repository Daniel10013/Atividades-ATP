namespace Exercises
{
    public class Exercise8 : BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("Digite a quantidade de veículos:");
            int veiculos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do aluguel por veículo:");
            decimal valorAluguel = decimal.Parse(Console.ReadLine());

            decimal faturamentoMensal = (veiculos * valorAluguel) / 3;
            decimal faturamentoAnual = faturamentoMensal * 12;

            decimal multasMensais = (faturamentoMensal / 10) * 0.2m;

            decimal manutencaoAnual = (veiculos * 0.02m) * 600;

            Console.WriteLine($"Faturamento Anual: {faturamentoAnual:C}");
            Console.WriteLine($"Valor ganho com multas no mês: {multasMensais:C}");
            Console.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual:C}");
            string caminhoArquivo = "./Files/resultado.txt";
            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine($"Faturamento Anual: {faturamentoAnual:C}");
                sw.WriteLine($"Valor ganho com multas no mês: {multasMensais:C}");
                sw.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual:C}");
            }

            Console.WriteLine($"Resultados gravados no arquivo: {caminhoArquivo}");
        }
    }
}