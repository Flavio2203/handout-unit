using Unidade2_1;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public int Potencia { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Carro carro1 = new Carro()
        {
            Marca = "Fiat",
            Modelo = "Punto",
            Ano = 2020,
            Cor = "Vermelho",
            Potencia = 120
        };

        Carro carro2 = new Carro()
        {
            Marca = "Volkswagem",
            Modelo = "Jetta",
            Ano = 2023,
            Cor = "Branco",
            Potencia = 140
        };

        Carro carro3 = new Carro()
        {
            Marca = "Chevrolet",
            Modelo = "Celta",
            Ano = 2022,
            Cor = "Prata",
            Potencia = 80
        };

        Console.WriteLine("Carro 1:");
        Console.WriteLine("Marca: " +carro1.Marca);
        Console.WriteLine("Modelo: " +carro1.Modelo);
        Console.WriteLine("Ano: " +carro1.Ano);
        Console.WriteLine("Cor: " +carro1.Cor);
        Console.WriteLine("Potência: " +carro1.Potencia);
        Console.WriteLine();

        Console.WriteLine("Carro 2:");
        Console.WriteLine("Marca: " +carro2.Marca);
        Console.WriteLine("Modelo: " +carro2.Modelo);
        Console.WriteLine("Ano: " +carro2.Ano);
        Console.WriteLine("Cor: " +carro2.Cor);
        Console.WriteLine("Potência: " +carro2.Potencia);
        Console.WriteLine();

        Console.WriteLine("Carro 3:");
        Console.WriteLine("Marca: " +carro3.Marca);
        Console.WriteLine("Modelo: " +carro3.Modelo);
        Console.WriteLine("Ano: " +carro3.Ano);
        Console.WriteLine("Cor: " +carro3.Cor);
        Console.WriteLine("Potência: " +carro3.Potencia);
    }
}
