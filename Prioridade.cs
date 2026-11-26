namespace SUAatualizado;

/// <summary>
/// Classificação de risco baseada no Protocolo de Manchester.
/// O número de cada cor define a ordem da fila: quanto menor, mais urgente.
/// </summary>
public enum Prioridade
{
    Vermelho = 1,
    Laranja = 2,
    Amarelo = 3,
    Verde = 4,
    Azul = 5
}

public static class PrioridadeExtensions
{
    public static string Descricao(this Prioridade prioridade) => prioridade switch
    {
        Prioridade.Vermelho => "Emergência",
        Prioridade.Laranja => "Muito urgente",
        Prioridade.Amarelo => "Urgente",
        Prioridade.Verde => "Pouco urgente",
        Prioridade.Azul => "Não urgente",
        _ => throw new ArgumentOutOfRangeException(nameof(prioridade))
    };

    public static string Detalhe(this Prioridade prioridade) => prioridade switch
    {
        Prioridade.Vermelho => "atendimento imediato",
        Prioridade.Laranja => "atendimento praticamente imediato",
        Prioridade.Amarelo => "atendimento rápido",
        Prioridade.Verde => "pode aguardar atendimento",
        Prioridade.Azul => "pode aguardar atendimento",
        _ => throw new ArgumentOutOfRangeException(nameof(prioridade))
    };

    public static ConsoleColor Cor(this Prioridade prioridade) => prioridade switch
    {
        Prioridade.Vermelho => ConsoleColor.Red,
        Prioridade.Laranja => ConsoleColor.DarkYellow,
        Prioridade.Amarelo => ConsoleColor.Yellow,
        Prioridade.Verde => ConsoleColor.Green,
        Prioridade.Azul => ConsoleColor.Cyan,
        _ => throw new ArgumentOutOfRangeException(nameof(prioridade))
    };
}
