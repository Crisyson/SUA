namespace SUAatualizado;

public static class ValidadorCpf
{
    public static string ApenasDigitos(string texto) => new(texto.Where(char.IsDigit).ToArray());

    /// <summary>
    /// Confere se o CPF tem 11 dígitos e se os dois dígitos verificadores estão corretos.
    /// </summary>
    public static bool EhValido(string cpf)
    {
        cpf = ApenasDigitos(cpf);

        // CPFs com todos os dígitos iguais (111.111.111-11) passam na conta, mas não existem.
        if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
            return false;

        int[] digitos = cpf.Select(c => c - '0').ToArray();

        return digitos[9] == CalcularDigito(digitos, 9)
            && digitos[10] == CalcularDigito(digitos, 10);
    }

    private static int CalcularDigito(int[] digitos, int quantidade)
    {
        int soma = 0;
        for (int i = 0; i < quantidade; i++)
            soma += digitos[i] * (quantidade + 1 - i);

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }
}
