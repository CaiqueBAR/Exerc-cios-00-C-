using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Temperatura Média do Verão Capixaba ===\n");
        
        double[] temperaturas = new double[15];
        double soma = 0;
        
        
        for (int i = 1; i <= 15; i++)
        {
            double temp = -1;
            bool validada = false;
            
            
            while (!validada)
            {
                Console.Write($"Digite a temperatura do dia {i} (°C): ");
                
                if (double.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 28 && temp <= 45) 
                    {
                        temperaturas[i - 1] = temp;
                        soma += temp;
                        validada = true;
                    }
                    else
                    {
                        Console.WriteLine("Erro! A temperatura deve ser maior que 28°C para o verão capixaba.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                }
            }
        }
        
        
        double media = soma / 15;
        

        Console.WriteLine($"\n=== Resultado ===");
        Console.WriteLine($"Temperatura média do verão capixaba: {media:F2}°C");
    }
}