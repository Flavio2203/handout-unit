using System;

public class Program
{
    public static void Main()
    {
        int ComprasAVista = 0;
        int ComprasAPrazo = 0;
        int ComprasEfetuadas = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Digite 'V' para compras à vista e 'P' para compras a prazo da transação {0}: ", i);
            string codigo = Console.ReadLine().ToUpper();

            Console.Write("Digite o valor da transação {0}: ", i);
            int valor = int.Parse(Console.ReadLine());

            if (codigo == "V")
            {
                ComprasAVista += valor;
            }
            else if (codigo == "P")
            {
                ComprasAPrazo += valor;
            }

            ComprasEfetuadas += valor;
        }

        Console.WriteLine();
        Console.WriteLine("Valor total das compras à vista: " +ComprasAVista);
        Console.WriteLine("Valor total das compras a prazo: " +ComprasAPrazo);
        Console.WriteLine("Valor total das compras efetuadas: " +ComprasEfetuadas);
    }
}
