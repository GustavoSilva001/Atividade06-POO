// Herança: Desenvolvedor herda de Funcionario e implementa CalcularCustoHora.
// Polimorfismo: cada tipo de funcionário define seu próprio custo por hora.
public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome)
    {
        Cargo = "Desenvolvedor";
    }

    // Custo fixo por hora para desenvolvedores (exemplo).
    public override double CalcularCustoHora()
    {
        return 100.0;
    }
}
