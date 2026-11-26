namespace SUAatualizado;

/// <summary>
/// Funções para ler dados do usuário e mostrar informações no console.
/// </summary>
public static class Tela
{
    public static void Titulo(string subtitulo)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==================================================");
        Console.WriteLine("   SUA - Sistema Único de Atendimento");
        Console.WriteLine($"   {subtitulo}");
        Console.WriteLine("==================================================");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void EscreverPrioridade(Prioridade prioridade)
    {
        Console.ForegroundColor = prioridade.Cor();
        Console.Write($"{prioridade.ToString().ToUpper()} - {prioridade.Descricao()}");
        Console.ResetColor();
    }

    public static void Sucesso(string mensagem) => EscreverColorido(mensagem, ConsoleColor.Green);

    public static void Erro(string mensagem) => EscreverColorido(mensagem, ConsoleColor.Red);

    public static void Pausar()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey(true);
    }

    public static string LerTexto(string pergunta)
    {
        while (true)
        {
            Console.Write(pergunta);
            string texto = (Console.ReadLine() ?? "").Trim();

            if (texto.Length > 0)
                return texto;

            Erro("Esse campo não pode ficar vazio.");
        }
    }

    public static int LerOpcao(string pergunta, int minimo, int maximo)
    {
        while (true)
        {
            Console.Write(pergunta);

            if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= minimo && opcao <= maximo)
                return opcao;

            Erro($"Opção inválida. Digite um número de {minimo} a {maximo}.");
        }
    }

    private static void EscreverColorido(string mensagem, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
}
