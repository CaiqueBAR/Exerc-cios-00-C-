using System;

class Program
{
    static void Main()
    {
        double totalGeral = 0.0;
        double totalLimpeza = 0.0;
        double totalAlimentacao = 0.0;
        double totalHigiene = 0.0;

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"Mercadoria {i}");

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Código (L/A/H): ");
            char codigo = char.Parse(Console.ReadLine());

            totalGeral += preco;

            switch (char.ToUpper(codigo))
            {
                case 'L':
                    totalLimpeza += preco;
                    break;

                case 'A':
                    totalAlimentacao += preco;
                    break;

                case 'H':
                    totalHigiene += preco;
                    break;

                default:
                    Console.WriteLine("Código inválido! Não será contabilizado por categoria.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("===== RESULTADO =====");
        Console.WriteLine($"Total da cesta básica: R$ {totalGeral:F2}");
        Console.WriteLine($"Total Limpeza: R$ {totalLimpeza:F2}");
        Console.WriteLine($"Total Alimentação: R$ {totalAlimentacao:F2}");
        Console.WriteLine($"Total Higiene: R$ {totalHigiene:F2}");
    }
}