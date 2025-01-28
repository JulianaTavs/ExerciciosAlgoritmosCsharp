using System.Globalization;

Console.Clear();
Console.WriteLine("Digite o número de dias trabalhados no mês: ");
int diasTrabalhados = LerNumero();
decimal salario = diasTrabalhados * 8 * 25;
Console.WriteLine($"O salário do funcionário é: {salario.ToString("C",
    CultureInfo.CreateSpecificCulture("en-GB"))} ");

static int LerNumero()
{
    int numero;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite um valor válido.");
            Thread.Sleep(2000);
            Console.WriteLine("Digite o número de dias trabalhados no mês: ");
        }
    }
}
