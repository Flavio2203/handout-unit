//Faça um programa em C# que leia uma quantidade indefinida de objetos Carro,
//composto pelos atributos, marca, valor, cor, modelo e ano, e:
//-Ordene os carros pelo de maior valor;
//-Imprima na tela todos os carros ordenados do maior valor para o de menor valor;
public class Carro
{
    public string Marca { get; set; }
    public decimal Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Carro> carros = new List<Carro>();

        while (true)
        {
            Console.WriteLine("Digite os dados do carro (ou digite 'sair' para encerrar):");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            if (marca.ToLower() == "sair")
                break;

            Console.Write("Valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Cor: ");
            string cor = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Carro carro = new Carro()
            {
                Marca = marca,
                Valor = valor,
                Cor = cor,
                Modelo = modelo,
                Ano = ano
            };

            carros.Add(carro);
        }

        carros.Sort((c1, c2) => c2.Valor.CompareTo(c1.Valor));

        Console.WriteLine("Os maiores valores de carro para os menores valores");
        foreach (Carro carro in carros)
        {
            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Valor: {carro.Valor:C2}");
            Console.WriteLine($"Cor: {carro.Cor}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine();
        }
    }
}
