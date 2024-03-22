using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Ativiade 1 - Exercício 7 \n");
    
        int daysWithoutAciddents, daysSubtracted, months, years, days;
        string messageDays, messageMonths, messageYears;
        //entrada de dados
        Console.WriteLine("Insiria a quantidade de dias sem acidentes: ");
        daysWithoutAciddents = int.Parse(Console.ReadLine());

        //processamento de dados
        years = daysWithoutAciddents / 365;
        daysSubtracted = daysWithoutAciddents % 365;

        months = daysSubtracted / 30;
        daysSubtracted = daysSubtracted % 30;

        days = daysSubtracted;

        //saide de dados
        Console.WriteLine(daysWithoutAciddents + " dias transformado para anos, meses e dias é: ");
        Console.WriteLine($"Anos: {years}, Meses: {months}, Dias: {days}");
    }
}

