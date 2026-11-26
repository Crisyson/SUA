namespace SUAatualizado;

public class FilaDeAtendimento
{
    private readonly List<Paciente> pacientes = new();

    public void Adicionar(Paciente paciente) => pacientes.Add(paciente);

    /// <summary>
    /// Pacientes que ainda não foram atendidos, do mais urgente para o menos urgente.
    /// Em caso de empate na prioridade, quem chegou primeiro é atendido primeiro.
    /// </summary>
    public List<Paciente> Aguardando() => pacientes
        .Where(p => !p.Atendido)
        .OrderBy(p => p.Prioridade)
        .ThenBy(p => p.Senha)
        .ToList();

    public List<Paciente> Atendidos() => pacientes
        .Where(p => p.Atendido)
        .ToList();

    public Paciente? Proximo() => Aguardando().FirstOrDefault();

    public bool CpfAguardando(string cpf) => pacientes.Any(p => !p.Atendido && p.Cpf == cpf);
}
