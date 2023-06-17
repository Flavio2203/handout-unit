using System;

class Program
{
    static int[] vetor;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirPares();
                    break;
                case 4:
                    ExibirImpares();
                    break;
                case 5:
                    ContarParesPosicoesImpares();
                    break;
                case 6:
                    ContarImparesPosicoesPares();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
                    break;
            }
        }
    }

    static void CarregarVetor()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Informe o valor para a posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!\n");
    }

    static void ListarVetor()
    {
        if (vetor == null)
        {
            Console.WriteLine("Nenhum vetor carregado!\n");
            return;
        }

        Console.WriteLine("Vetor:");

        foreach (int valor in vetor)
        {
            Console.Write($"{valor} ");
        }

        Console.WriteLine("\n");
    }

    static void ExibirPares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Nenhum vetor carregado!\n");
            return;
        }

        Console.WriteLine("Números pares:");

        foreach (int valor in vetor)
        {
            if (valor % 2 == 0)
            {
                Console.Write($"{valor} ");
            }
        }

        Console.WriteLine("\n");
    }

    static void ExibirImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Nenhum vetor carregado!\n");
            return;
        }

        Console.WriteLine("Números ímpares:");

        foreach (int valor in vetor)
        {
            if (valor % 2 != 0)
            {
                Console.Write($"{valor} ");
            }
        }

        Console.WriteLine("\n");
    }

    static void ContarParesPosicoesImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Nenhum vetor carregado!\n");
            return;
        }

        int count = 0;

        for (int i = 1; i < vetor.Length;) ;
    }
}
    

