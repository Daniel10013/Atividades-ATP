using System;
using System.IO;

class Program
{
    static string[] produtos = new string[4];
    static int[] estoque = new int[4];
    static int[,] vendas = new int[30, 4];

    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1 – Importar arquivo de produtos");
            Console.WriteLine("2 – Registrar venda");
            Console.WriteLine("3 – Relatório de vendas");
            Console.WriteLine("4 – Relatório de estoque");
            Console.WriteLine("5 – Criar arquivo de vendas");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ImportarArquivoProdutos();
                    break;
                case 2:
                    RegistrarVenda();
                    break;
                case 3:
                    RelatorioDeVendas();
                    break;
                case 4:
                    RelatorioDeEstoque();
                    break;
                case 5:
                    CriarArquivoDeVendas();
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 6)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcao != 6);
    }

    static void ImportarArquivoProdutos()
    {
        using (StreamReader sr = new StreamReader("produtos.txt"))
        {
            for (int i = 0; i < 4; i++)
            {
                string[] dados = sr.ReadLine().Split(' ');
                produtos[i] = dados[0];
                estoque[i] = int.Parse(dados[1]);
            }
        }
        Console.WriteLine("Arquivo importado com sucesso.");
    }

    static void RegistrarVenda()
    {
        Console.Write("Digite o número do produto (1-4): ");
        int produtoIndex = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Digite o dia do mês (1-30): ");
        int dia = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Digite a quantidade vendida: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade > estoque[produtoIndex])
        {
            Console.WriteLine("Erro: Quantidade vendida ultrapassa o estoque disponível.");
        }
        else
        {
            vendas[dia, produtoIndex] += quantidade;
            estoque[produtoIndex] -= quantidade;
            Console.WriteLine("Venda registrada com sucesso.");
        }
    }

    static void RelatorioDeVendas()
    {
        Console.WriteLine("Relatório de Vendas:");
        Console.WriteLine("Dia\tProduto A\tProduto B\tProduto C\tProduto D");
        for (int dia = 0; dia < 30; dia++)
        {
            Console.Write((dia + 1) + "\t");
            for (int produto = 0; produto < 4; produto++)
            {
                Console.Write(vendas[dia, produto] + "\t\t");
            }
            Console.WriteLine();
        }
    }

    static void RelatorioDeEstoque()
    {
        Console.WriteLine("Relatório de Estoque Atualizado:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(produtos[i] + " " + estoque[i]);
        }
    }

    static void CriarArquivoDeVendas()
    {
        using (StreamWriter sw = new StreamWriter("total_vendas.txt"))
        {
            for (int produto = 0; produto < 4; produto++)
            {
                int totalVendas = 0;
                for (int dia = 0; dia < 30; dia++)
                {
                    totalVendas += vendas[dia, produto];
                }
                sw.WriteLine(produtos[produto] + " " + totalVendas);
            }
        }
        Console.WriteLine("Arquivo de vendas criado com sucesso.");
    }
}
