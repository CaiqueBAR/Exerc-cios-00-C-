using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.WriteLine("\n=== Conversor de Temperatura ===");
            Console.WriteLine("1. Celsius → Fahrenheit (°F = °C × 1,8 + 32)");
            Console.WriteLine("2. Fahrenheit → Celsius (°C = (°F - 32) / 1,8)");
            Console.WriteLine("3. Celsius → Kelvin (K = °C + 273,15)");
            Console.WriteLine("4. Kelvin → Celsius (°C = K - 273,15)");
            Console.WriteLine("5. Sair");
            Console.Write("\nEscolha uma opção (1-5): ");
            
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a temperatura em Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        double fahrenheit = ConverterCelsiusParaFahrenheit(celsius);
                        Console.WriteLine($"\nResultado: {celsius}°C = {fahrenheit:F2}°F");
                    }
                    else
                        Console.WriteLine("Entrada inválida!");
                    break;
                    
                case "2":
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fahrenheit2))
                    {
                        double celsius2 = ConverterFahrenheitParaCelsius(fahrenheit2);
                        Console.WriteLine($"\nResultado: {fahrenheit2}°F = {celsius2:F2}°C");
                    }
                    else
                        Console.WriteLine("Entrada inválida!");
                    break;
                    
                case "3":
                    Console.Write("Digite a temperatura em Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius3))
                    {
                        double kelvin = ConverterCelsiusParaKelvin(celsius3);
                        Console.WriteLine($"\nResultado: {celsius3}°C = {kelvin:F2}K");
                    }
                    else
                        Console.WriteLine("Entrada inválida!");
                    break;
                    
                case "4":
                    Console.Write("Digite a temperatura em Kelvin: ");
                    if (double.TryParse(Console.ReadLine(), out double kelvin2))
                    {
                        double celsius4 = ConverterKelvinParaCelsius(kelvin2);
                        Console.WriteLine($"\nResultado: {kelvin2}K = {celsius4:F2}°C");
                    }
                    else
                        Console.WriteLine("Entrada inválida!");
                    break;
                    
                case "5":
                    continuar = false;
                    Console.WriteLine("\nEncerrando programa...");
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
    
    // Métodos de conversão
    static double ConverterCelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 1.8) + 32;
    }
    
    static double ConverterFahrenheitParaCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) / 1.8;
    }
    
    static double ConverterCelsiusParaKelvin(double celsius)
    {
        return celsius + 273.15;
    }
    
    static double ConverterKelvinParaCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }
}