Console.WriteLine("Digite seu salário atual: ");
decimal salarioAtual = LerSalario();

int sexo = LerSexo(1, 2);

Console.WriteLine("Quantos anos você tem de empresa: ");
double anosDeEmpresa = LerAnosEmpresa(0, 60);

decimal salarioReajustado = LerReajusteSalario(sexo, anosDeEmpresa, salarioAtual);

string genero = LerTexto(sexo);

System.Console.WriteLine("------------------------------------------------");
System.Console.WriteLine($"Sexo: {genero}");
System.Console.WriteLine($"Tempo de empresa: {anosDeEmpresa}");
System.Console.WriteLine($"Salário atual: {salarioAtual:C}");
System.Console.WriteLine($"Salário reajustado: {salarioReajustado:C}");
System.Console.WriteLine("------------------------------------------------");

static decimal LerSalario()
{
    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Digite um valor válido para o seu salário atual: ");
        }
    }
}

static int LerSexo(int opcao1, int opcao2)
{
    Console.WriteLine("Entre com o seu gênero:");
    System.Console.WriteLine("1 - feminino");
    System.Console.WriteLine("2 - masculino");

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor) && (valor == opcao1 || valor == opcao2))
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar 1 para sexo FEMININO e 2 para sexo" +
            " MASCULINO.");
        }
    }
}

static double LerAnosEmpresa(double min, double max)
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double valor) && valor >= min && valor <= max)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Por favor, " +
            "insira um valor entre 0 e 60 para o tempo de serviço:");
        }
    }
}

static decimal LerReajusteSalario(int sexo, double anosDeEmpresa, decimal salarioAtual)
{
    /* 
    - Mulheres:
    - menos de 15 anos de empresa: +5%
    - de 15 até 20 anos de empresa: +12%
    - mais de 20 anos de empresa: +23%
    - Homens:
    - menos de 20 anos de empresa: +3%
    - de 20 até 30 anos de empresa: +13%
    - mais de 30 anos de empresa: +25%
    */

    decimal salario;
    if (sexo == 1) // Mulher
    {
        if (anosDeEmpresa < 15)
        {
            salario = salarioAtual + salarioAtual * 0.05m;
        }
        else if (anosDeEmpresa <= 20)
        {
            salario = salarioAtual + salarioAtual * 0.12m;
        }
        else
        {
            salario = salarioAtual + salarioAtual * 0.23m;
        }
    }
    else // Homem
    {
        if (anosDeEmpresa < 20)
        {
            salario = salarioAtual + salarioAtual * 0.03m;
        }
        else if (anosDeEmpresa <= 30)
        {
            salario = salarioAtual + salarioAtual * 0.13m;
        }
        else
        {
            salario = salarioAtual + salarioAtual * 0.25m;
        }
    }
    return salario;
}

// Função para retornar o gênero por extenso
static string LerTexto(int sexo)
{
    return sexo == 1 ? "Feminino" : "Masculino";
}