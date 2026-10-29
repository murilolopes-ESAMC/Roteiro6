using System.Globalization;
using Exercicio2;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 02: Conversão de temperatura ---");

float temperatura;

// Repete a entrada até que o valor seja válido
while (true)
{
    try
    {
        Console.Write("Digite a temperatura em Celsius: ");
        temperatura = ConversorTemperatura.ConverterParaCelsius(Console.ReadLine() ?? "");
        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Erro: {ex.Message} Tente novamente.");
    }
}

Console.WriteLine($"Temperatura registrada: {temperatura} °C");
