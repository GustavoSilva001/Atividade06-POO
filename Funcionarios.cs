public abstract class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; protected set; }

    public Funcionario(string nome)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public abstract double CalcularCustoHora();
}
