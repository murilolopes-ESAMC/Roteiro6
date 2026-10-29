namespace Exercicio4;

public class ControleAcesso
{
    public static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }

        Console.WriteLine("Acesso permitido.");
    }
}
