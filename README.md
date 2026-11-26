<p align="center">
  <img src="LOGO.png" alt="Logo do SUA" width="160">
</p>

<h1 align="center">SUA — Sistema Único de Atendimento</h1>

<p align="center">
  Sistema de triagem e atendimento hospitalar no console, feito em C# durante o curso técnico.
</p>

---

## Sobre o projeto

O SUA simula o fluxo de um pronto-atendimento: o paciente é cadastrado na recepção, recebe uma **classificação de risco por cores** (baseada no Protocolo de Manchester) e entra numa fila que é **ordenada automaticamente pela urgência**. O médico chama o próximo da fila, registra a consulta, pode encaminhar para exame e voltar para a consulta quantas vezes precisar, e tudo fica salvo no histórico do paciente.

## Funcionalidades

- **Cadastro com triagem:** nome, CPF, endereço, sintomas e prioridade.
- **Validação de CPF:** confere os dígitos verificadores e impede cadastrar o mesmo paciente duas vezes na fila.
- **Fila por prioridade:** quem é mais urgente é atendido primeiro; em caso de empate, vale a ordem de chegada.
- **Atendimento em etapas:** consulta → exame → consulta → ... até o médico finalizar.
- **Histórico:** cada relatório de consulta e resultado de exame é guardado com o horário.
- **Interface colorida:** cada prioridade aparece com a sua cor no console.

| Cor | Classificação | Atendimento |
|---|---|---|
| 🔴 Vermelho | Emergência | Imediato |
| 🟠 Laranja | Muito urgente | Praticamente imediato |
| 🟡 Amarelo | Urgente | Rápido |
| 🟢 Verde | Pouco urgente | Pode aguardar |
| 🔵 Azul | Não urgente | Pode aguardar |

## Como executar

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) 6 ou superior.

```bash
git clone https://github.com/Crisyson/SUA.git
cd SUA
dotnet run
```

> Para testar, use um CPF válido (dá para gerar um em qualquer gerador de CPF para testes).

## Estrutura do código

```
SUA/
├── Program.cs            # Menu principal e fluxo de cadastro, fila e atendimento
├── Paciente.cs           # Dados do paciente e histórico de atendimento
├── Prioridade.cs         # Enum das cores de risco, com descrição e cor no console
├── FilaDeAtendimento.cs  # Lista de pacientes ordenada por prioridade e chegada
├── ValidadorCpf.cs       # Validação dos dígitos verificadores do CPF
└── Tela.cs               # Leitura de dados e saída formatada no console
```

## Conceitos aplicados

- Programação orientada a objetos (classes, encapsulamento, propriedades)
- `enum` com métodos de extensão
- Coleções (`List<T>`) e consultas com LINQ (`Where`, `OrderBy`, `ThenBy`)
- Validação de entrada do usuário
- Separação de responsabilidades em arquivos

## Próximos passos

- [ ] Salvar os pacientes em arquivo ou banco de dados (hoje os dados ficam só na memória)
- [ ] Testes unitários para o validador de CPF e a ordenação da fila
- [ ] Versão com interface gráfica ou web

## Autor

Feito por **Crisyson** — [github.com/Crisyson](https://github.com/Crisyson)
