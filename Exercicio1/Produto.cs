namespace Exercicio1;

public class Produto
{
    public string Nome { get; }
    public decimal Preco { get; }

    public Produto(string nome, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do produto não pode ficar em branco.");
        }

        if (preco <= 0)
        {
            throw new ArgumentException("O preço do produto deve ser maior que zero.");
        }

        Nome = nome.Trim();
        Preco = preco;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Produto cadastrado: {Nome} | Preço: {Preco:C}");
    }
}
