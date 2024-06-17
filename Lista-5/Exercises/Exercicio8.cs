namespace Exercises
{
    public class Exercise8: BaseExercise
    {
        static void Run()
        {
            int[,] matriz = new int[4, 4];
            PreencherMatriz(matriz);

            Console.WriteLine("Matriz 4x4 preenchida:");
            ImprimirMatriz(matriz);

            int somaAbaixoDiagonal = SomaAbaixoDiagonalPrincipal(matriz);
            Console.WriteLine($"Soma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");

            Console.WriteLine("Elementos da diagonal principal:");
            ImprimirDiagonalPrincipal(matriz);
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int SomaAbaixoDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }

        static void ImprimirDiagonalPrincipal(int[,] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }
        }
    }
}