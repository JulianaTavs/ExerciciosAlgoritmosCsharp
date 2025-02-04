using System.Text.RegularExpressions;

Console.WriteLine("Digite o nome do funcionário: ");
string nome = LerNome();

Console.WriteLine("Digite o salário do funcionário: ");
decimal salario = LerSalario();

Console.WriteLine("Digite quantos anos o funcionário trabalha na empresa: ");
int anosDeEmpresa = LerAnos();

decimal salarioReajustado;

// Calcula o reajuste com base nos anos de empresa
if (anosDeEmpresa <= 3)
{
    salarioReajustado = salario + salario * 0.03m;
}
else if (anosDeEmpresa < 10)
{
    salarioReajustado = salario + salario * 0.12m;
}
else
{
    salarioReajustado = salario + salario * 0.20m;
}

System.Console.WriteLine($"SALÁRIO REAJUSTADO: {salarioReajustado.ToString("C")}");

static string LerNome()
{
    while (true)
    {
        string? data = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(data))
        {
            // Expressão regular para permitir apenas letras e espaços
            Regex regex = new Regex(@"^[a-zA-ZÀ-ÿ\s]+$");
            if (regex.IsMatch(data)) // Verifica se o nome contém apenas letras e espaços
            {
                return data;
            }
            else
            {
                System.Console.WriteLine("Nome inválido! O nome deve conter apenas letras e espaços.");
            }
        }
        else
        {
            System.Console.WriteLine("Favor digitar um nome válido: ");
        }
    }
}

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
            System.Console.WriteLine("Valor inválido. Valor digitar um salário maior que zero:");
        }
    }
}

static int LerAnos()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int anos) && anos >= 0)
        {
            return anos;
        }
        else
        {
            System.Console.WriteLine("Valor inválido. Valor digitar a quantos anos o" +
            " funcionário trabalha na empresa:");
        }
    }
}

