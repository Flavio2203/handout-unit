public class Program
{
    public static void Main()
    {
        int contador = 0;
        int valor;
        int maior = int.MinValue;
        int menor = int.MaxValue;
        int soma = 0;

        do
        {
            Console.Write("Digite um valor inteiro: ");
            valor = int.Parse(Console.ReadLine());

            if (valor > maior)
                maior = valor;

            if (valor < menor)
                menor = valor;

            soma += valor;

            contador++;
        }
        while (contador < 20);

        double media = (double)soma / 20;

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Média dos números lidos: " + media);
    }
}
