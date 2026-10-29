using Exercicio4;

Console.WriteLine("--- Exercício 04: Exceção personalizada para idade ---");

Console.Write("Digite a idade: ");

try
{
    int idade = int.Parse(Console.ReadLine() ?? "");
    ControleAcesso.VerificarIdade(idade);
}
catch (IdadeInvalidaException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
catch (FormatException)
{
    Console.WriteLine("Erro: digite uma idade válida (número inteiro).");
}
