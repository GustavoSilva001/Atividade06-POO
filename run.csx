#r "System.Console"
using System;
using System.Collections.Generic;
using System.Linq;

// ======= Classes do sistema =======

public abstract class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; protected set; }

    public Funcionario(string nome) => Nome = nome;

    public abstract double CalcularCustoHora();
}

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome) => Cargo = "Desenvolvedor";
    public override double CalcularCustoHora() => 100.0;
}

public class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome) => Cargo = "Gerente";
    public override double CalcularCustoHora() => 150.0;
}

public class Alocacao
{
    public Funcionario Funcionario { get; private set; }
    public int Horas { get; private set; }

    public Alocacao(Funcionario funcionario, int horas)
    {
        Funcionario = funcionario;
        Horas = horas;
    }
}

public class Projeto
{
    public string Nome { get; private set; }
    public List<Alocacao> Alocacoes { get; private set; } = new List<Alocacao>();

    public Projeto(string nome) => Nome = nome;

    public void AdicionarAlocacao(Funcionario funcionario, int horas)
    {
        if (horas <= 0)
            throw new ArgumentException("Horas devem ser maiores que zero.");
        Alocacoes.Add(new Alocacao(funcionario, horas));
    }

    public double CalcularCustoTotal()
    {
        return Alocacoes.Sum(a => a.Horas * a.Funcionario.CalcularCustoHora());
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Projeto: {Nome}");
        foreach (var aloc in Alocacoes)
        {
            Console.WriteLine($"- {aloc.Funcionario.Cargo}: {aloc.Funcionario.Nome} ({aloc.Horas}h)");
        }
        Console.WriteLine($"Custo total: R${CalcularCustoTotal():F2}");
    }
}

// ======= Simulação =======

var dev = new Desenvolvedor("Alice");
var gerente = new Gerente("Carlos");

var projeto = new Projeto("Sistema ERP");
projeto.AdicionarAlocacao(dev, 20);
projeto.AdicionarAlocacao(gerente, 10);

projeto.ExibirDetalhes();
