using System.Text;

namespace SUAatualizado;

internal class Program
{
    private static readonly FilaDeAtendimento fila = new();

    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Tela.Titulo("Menu principal");
            Console.WriteLine($"Pacientes aguardando: {fila.Aguardando().Count}");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar paciente (triagem)");
            Console.WriteLine("2 - Ver fila de atendimento");
            Console.WriteLine("3 - Chamar próximo paciente");
            Console.WriteLine("4 - Ver pacientes atendidos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            switch (Tela.LerOpcao("Escolha uma opção: ", 0, 4))
            {
                case 1: CadastrarPaciente(); break;
                case 2: MostrarFila(); break;
                case 3: ChamarProximo(); break;
                case 4: MostrarAtendidos(); break;
                case 0: return;
            }
        }
    }

    private static void CadastrarPaciente()
    {
        Tela.Titulo("Cadastro e triagem");

        string nome = Tela.LerTexto("Nome do paciente: ");
        string cpf = LerCpf();
        string endereco = Tela.LerTexto("Endereço: ");
        string sintomas = Tela.LerTexto("Sintomas: ");

        Console.WriteLine();
        Console.WriteLine("Classificação de risco:");
        foreach (Prioridade opcao in Enum.GetValues<Prioridade>())
        {
            Console.Write($"  {(int)opcao} - ");
            Tela.EscreverPrioridade(opcao);
            Console.WriteLine($" ({opcao.Detalhe()})");
        }
        var prioridade = (Prioridade)Tela.LerOpcao("Escolha a prioridade: ", 1, 5);

        var paciente = new Paciente(nome, cpf, endereco, sintomas, prioridade);
        fila.Adicionar(paciente);

        Console.WriteLine();
        Tela.Sucesso($"Paciente {paciente.Nome} cadastrado. Senha: {paciente.Senha:D3}");
        Console.Write("Prioridade: ");
        Tela.EscreverPrioridade(prioridade);
        Console.WriteLine();
        Tela.Pausar();
    }

    private static string LerCpf()
    {
        while (true)
        {
            string cpf = ValidadorCpf.ApenasDigitos(Tela.LerTexto("CPF: "));

            if (!ValidadorCpf.EhValido(cpf))
                Tela.Erro("CPF inválido. Confira os números e tente de novo.");
            else if (fila.CpfAguardando(cpf))
                Tela.Erro("Esse paciente já está na fila.");
            else
                return cpf;
        }
    }

    private static void MostrarFila()
    {
        Tela.Titulo("Fila de atendimento");
        var aguardando = fila.Aguardando();

        if (aguardando.Count == 0)
            Console.WriteLine("Nenhum paciente aguardando.");

        for (int i = 0; i < aguardando.Count; i++)
        {
            var paciente = aguardando[i];
            Console.Write($"{i + 1,2}º  Senha {paciente.Senha:D3}  {paciente.Nome,-25} ");
            Tela.EscreverPrioridade(paciente.Prioridade);
            Console.WriteLine($"  (chegou às {paciente.Chegada:HH:mm})");
        }

        Tela.Pausar();
    }

    private static void ChamarProximo()
    {
        var paciente = fila.Proximo();

        if (paciente is null)
        {
            Tela.Titulo("Atendimento");
            Console.WriteLine("Nenhum paciente aguardando.");
            Tela.Pausar();
            return;
        }

        Atender(paciente);
    }

    /// <summary>
    /// O atendimento alterna entre consulta e exame até o médico finalizar.
    /// Cada relatório fica salvo no histórico do paciente.
    /// </summary>
    private static void Atender(Paciente paciente)
    {
        bool emConsulta = true;

        while (true)
        {
            MostrarFicha(paciente);

            string etapa = emConsulta ? "Consulta médica" : "Exame";
            string relatorio = Tela.LerTexto(emConsulta ? "Relatório da consulta: " : "Resultado do exame: ");
            paciente.AdicionarRegistro(etapa, relatorio);

            Console.WriteLine();
            Console.WriteLine(emConsulta ? "1 - Encaminhar para exame" : "1 - Voltar para consulta médica");
            Console.WriteLine("2 - Finalizar atendimento");

            if (Tela.LerOpcao("Escolha: ", 1, 2) == 2)
                break;

            emConsulta = !emConsulta;
        }

        paciente.FinalizarAtendimento();
        MostrarFicha(paciente);
        Tela.Sucesso("Atendimento finalizado.");
        Tela.Pausar();
    }

    private static void MostrarFicha(Paciente paciente)
    {
        Tela.Titulo($"Atendimento - senha {paciente.Senha:D3}");
        Console.WriteLine($"Paciente:   {paciente.Nome}");
        Console.WriteLine($"CPF:        {paciente.CpfFormatado}");
        Console.WriteLine($"Endereço:   {paciente.Endereco}");
        Console.WriteLine($"Sintomas:   {paciente.Sintomas}");
        Console.Write("Prioridade: ");
        Tela.EscreverPrioridade(paciente.Prioridade);
        Console.WriteLine();

        if (paciente.Historico.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Histórico:");
            foreach (string registro in paciente.Historico)
                Console.WriteLine($"  {registro}");
        }

        Console.WriteLine();
    }

    private static void MostrarAtendidos()
    {
        Tela.Titulo("Pacientes atendidos");
        var atendidos = fila.Atendidos();

        if (atendidos.Count == 0)
            Console.WriteLine("Nenhum paciente atendido ainda.");

        foreach (var paciente in atendidos)
        {
            Console.Write($"Senha {paciente.Senha:D3}  {paciente.Nome,-25} ");
            Tela.EscreverPrioridade(paciente.Prioridade);
            Console.WriteLine($"  ({paciente.Historico.Count} registro(s) no histórico)");
        }

        Tela.Pausar();
    }
}
