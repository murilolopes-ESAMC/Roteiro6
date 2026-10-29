Console.WriteLine("--- Exercício 03: Entrada de número inteiro ---");

Console.Write("Digite um número: ");
string entrada = Console.ReadLine() ?? "";

try
{
    int numero = int.Parse(entrada); // Lança FormatException se não for um número
    Console.WriteLine($"Você digitou o número {numero}.");
}
catch (FormatException)
{
    Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
}
catch (OverflowException)
{
    Console.WriteLine("Valor inválido. O número está fora do intervalo permitido para int.");
}
