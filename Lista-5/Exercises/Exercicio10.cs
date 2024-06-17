namespace Exercises
{
    public class Exercise10: BaseExercise
    {
        static void Run()
        {
            int[,] matriz = new int[10, 10];
            PreencherMatriz(matriz);

            Console.WriteLine("Matriz Original:");
            ImprimirMatriz(matriz);

            TrocarLinhas(matriz, 2, 8);
            Console.WriteLine("Matriz após trocar linha 2 com linha 8:");
            ImprimirMatriz(matriz);

            TrocarColunas(matriz, 4, 10);
            Console.WriteLine("Matriz após trocar coluna 4 com coluna 10:");
            ImprimirMatriz(matriz);

            TrocarDiagonais(matriz);
            Console.WriteLine("Matriz após trocar diagonal principal com diagonal secundária:");
            ImprimirMatriz(matriz);

            TrocarLinhaComColuna(matriz, 5, 10);
            Console.WriteLine("Matriz após trocar linha 5 com coluna 10:");
            ImprimirMatriz(matriz);
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
        {
            for (int j = 0; j < 10; j++)
            {
                int temp = matriz[linha1, j];
                matriz[linha1, j] = matriz[linha2, j];
                matriz[linha2, j] = temp;
            }
        }

        static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = matriz[i, coluna1];
                matriz[i, coluna1] = matriz[i, coluna2];
                matriz[i, coluna2] = temp;
            }
        }

        static void TrocarDiagonais(int[,] matriz)
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = matriz[i, i];
                matriz[i, i] = matriz[i, 9 - i];
                matriz[i, 9 - i] = temp;
            }
        }

        static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = matriz[linha, i];
                matriz[linha, i] = matriz[i, coluna];
                matriz[i, coluna] = temp;
            }
        }
    }
}