using System;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public int Potencia { get; set; }

    public string Acelerar()
    {
        return "O carro está em movimento";
    }

    public string Freiar()
    {
        return "O carro está parado";
    }
}

public class Program
{
    public static void Main()
    {
        Carro carro1 = new Carro()
        {
            Marca = "Punto",
            Modelo = "Fiat",
            Ano = 2020,
            Cor = "Vermelho",
            Potencia = 120
        };

        Console.WriteLine("Carro 1:");
        Console.WriteLine("Marca: " + carro1.Marca);
        Console.WriteLine("Modelo: " + carro1.Modelo);
        Console.WriteLine("Ano: " + carro1.Ano);
        Console.WriteLine("Cor: " + carro1.Cor);
        Console.WriteLine("Potência: " + carro1.Potencia);
        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Freiar());
    }
}
