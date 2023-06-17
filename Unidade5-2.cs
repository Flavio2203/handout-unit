using System;
using System.Collections.Generic;

interface ICarroManager
{
    void CadastrarCarro(List<Carro> carros);
    void ExcluirCarro(List<Carro> carros);
    void ListarCarros(List<Carro> carros);
}

class Carro
{
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class CarroManager : ICarroManager
{
    public void CadastrarCarro(List<Carro> carros)
    {
        Carro carro = new Carro();

        Console.Write("Marca: ");
        carro.Marca = Console.ReadLine();

        Console.Write("Valor: ");
        carro.Valor = double.Parse(Console.ReadLine());

        Console.Write("Cor: ");
        carro.Cor = Console.ReadLine();

        Console.Write("Modelo: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        carro.Ano = int.Parse(Console.ReadLine());

        carros.Add(carro);

        Console.WriteLine("Carro cadastrado com sucesso!\n");
    }

    public void ExcluirCarro(List<Carro> carros)
    {
        Console.Write("Digite o índice do carro que deseja excluir: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < carros.Count)
        {
            carros.RemoveAt(indice);
            Console.WriteLine("Carro excluído com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Índice inválido!\n");
        }
    }

    public void ListarCarros(List<Carro> carros)
    {
        if (carros.Count == 0)
        {
            Console.WriteLine("Nenhum carro cadastrado!\n");
            return;
        }

        carros.Sort((x, y) => x.Valor.CompareTo(y.Valor));

        Console.WriteLine("Carros ordenados pelo menor valor:\n");

        foreach (Carro carro in carros)
        {
            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Valor: {carro.Valor}");
            Console.WriteLine($"Cor: {carro.Cor}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Carro> carros = new List<Carro>();
        CarroManager carroManager = new CarroManager();

        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar Carro");
            Console.WriteLine("2 - Excluir Carro");
            Console.WriteLine("3 - Listar Carros");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    carroManager.CadastrarCarro(carros);
                    break;
                case 2:
                    carroManager.ExcluirCarro(carros);
                    break;
                case 3:
                    carroManager.ListarCarros(carros);
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

