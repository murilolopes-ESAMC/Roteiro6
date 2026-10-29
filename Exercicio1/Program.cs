using System.Globalization;
using Exercicio1;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 01: Validação de produto ---");

try
{
    Console.Write("Nome do produto: ");
    string nome = Console.ReadLine() ?? "";

    Console.Write("Preço do produto: ");
    decimal preco = decimal.Parse(Console.ReadLine() ?? ""); // Pode lançar FormatException

    Produto produto = new Produto(nome, preco); // Pode lançar ArgumentException
    produto.ExibirDados();
}
catch (FormatException)
{
    Console.WriteLine("Erro: o preço informado não é um número válido.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Fim do cadastro.");
}
