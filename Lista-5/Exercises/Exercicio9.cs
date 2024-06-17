namespace Exercises
{
    public class Exercise9: BaseExercise
    {
        static void Run()
        {
            int[,] matrizA = new int[4, 6];
            int[,] matrizB = new int[4, 6];

            PreencherMatriz(matrizA);
            PreencherMatriz(matrizB);

            Console.WriteLine("Matriz A:");
            ImprimirMatriz(matrizA);

            Console.WriteLine("Matriz B:");
            ImprimirMatriz(matrizB);

            int[,] matrizSoma = SomaMatrizes(matrizA, matrizB);
            Console.WriteLine("Matriz Soma (A + B):");
            ImprimirMatriz(matrizSoma);

            int[,] matrizDiferenca = DiferencaMatrizes(matrizA, matrizB);
            Console.WriteLine("Matriz Diferença (A - B):");
            ImprimirMatriz(matrizDiferenca);
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random rand = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] SomaMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int linhas = matrizA.GetLength(0);
            int colunas = matrizA.GetLength(1);
            int[,] matrizSoma = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            return matrizSoma;
        }

        static int[,] DiferencaMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int linhas = matrizA.GetLength(0);
            int colunas = matrizA.GetLength(1);
            int[,] matrizDiferenca = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrizDiferenca[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            return matrizDiferenca;
        }
    }
}