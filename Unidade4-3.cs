public class Program
{
    public static void Main()
    {
        int quantidadePessoas = 200;
        int salarioTotal = 0;
        int numeroFilhosTotal = 0;
        int maiorSalario = int.MinValue;
        int menorSalario = int.MaxValue;
        int quantidadeSalariosAte1500 = 0;

        for (int i = 1; i <= quantidadePessoas; i++)
        {
            Console.WriteLine("Dados da pessoa {0}:", i);
            Console.Write("Digite o salário: R$");
            int salario = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de filhos: ");
            int numeroFilhos = int.Parse(Console.ReadLine());

            salarioTotal += salario;
            numeroFilhosTotal += numeroFilhos;

            if (salario > maiorSalario)
                maiorSalario = salario;

            if (salario < menorSalario)
                menorSalario = salario;

            if (salario <= 1500)
                quantidadeSalariosAte1500++;
        }

        double mediaSalario = (double)salarioTotal / quantidadePessoas;
        double mediaFilhos = (double)numeroFilhosTotal / quantidadePessoas;
        double percentualSalariosAte1500 = (double)quantidadeSalariosAte1500 / quantidadePessoas * 100;

        Console.WriteLine();
        Console.WriteLine("Média do salário: R$" + mediaSalario.ToString("0.00"));
        Console.WriteLine("Média do número de filhos: " + mediaFilhos.ToString("0.00"));
        Console.WriteLine("Maior salário: R$" + maiorSalario);
        Console.WriteLine("Menor salário: R$" + menorSalario);
        Console.WriteLine("Porcentagem de pessoas com salários até R$1500,00: " + percentualSalariosAte1500.ToString("0.00") + "%");
    }
}

