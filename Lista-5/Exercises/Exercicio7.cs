namespace Exercises
{
    public class Exercise7: BaseExercise
    {
         static void Run()
        {
            int[,] matriz = new int[5, 5];
            PreencherMatriz(matriz);

            Console.WriteLine("Matriz 5x5 preenchida:");
            ImprimirMatriz(matriz);

            Console.WriteLine($"Soma da linha 4: {SomaLinha(matriz, 4)}");
            Console.WriteLine($"Soma da coluna 2: {SomaColuna(matriz, 2)}");
            Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(matriz)}");
            Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(matriz)}");
            Console.WriteLine($"Soma de todos os elementos: {SomaTodosElementos(matriz)}");
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 101); // Preenchendo com valores entre 1 e 100
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int SomaLinha(int[,] matriz, int linha)
        {
            int soma = 0;
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[linha, j];
            }
            return soma;
        }

        static int SomaColuna(int[,] matriz, int coluna)
        {
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma += matriz[i, coluna];
            }
            return soma;
        }

        static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma += matriz[i, i];
            }
            return soma;
        }

        static int SomaDiagonalSecundaria(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma += matriz[i, 4 - i];
            }
            return soma;
        }

        static int SomaTodosElementos(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }
    }
}