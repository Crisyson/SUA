namespace SUAatualizado;

public class Paciente
{
    private static int proximaSenha = 1;

    public int Senha { get; }
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
    public string Sintomas { get; }
    public Prioridade Prioridade { get; }
    public DateTime Chegada { get; }
    public bool Atendido { get; private set; }
    public List<string> Historico { get; } = new();

    public Paciente(string nome, string cpf, string endereco, string sintomas, Prioridade prioridade)
    {
        Senha = proximaSenha++;
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
        Sintomas = sintomas;
        Prioridade = prioridade;
        Chegada = DateTime.Now;
    }

    public string CpfFormatado => $"{Cpf[..3]}.{Cpf[3..6]}.{Cpf[6..9]}-{Cpf[9..]}";

    public void AdicionarRegistro(string tipo, string texto) =>
        Historico.Add($"[{DateTime.Now:HH:mm}] {tipo}: {texto}");

    public void FinalizarAtendimento() => Atendido = true;
}
