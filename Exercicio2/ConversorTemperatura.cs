namespace Exercicio2;

public class ConversorTemperatura
{
    public static float ConverterParaCelsius(string entrada)
    {
        if (!float.TryParse(entrada, out float celsius))
        {
            throw new FormatException($"\"{entrada}\" não é uma temperatura válida.");
        }

        return celsius;
    }
}
