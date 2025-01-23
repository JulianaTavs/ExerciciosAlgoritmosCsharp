Console.Clear();
Console.WriteLine("Digite o número de dias trabalhados no mês: ");
int diasTrabalhados = LerNumero();
int salario = diasTrabalhados * (8 * 25);
Console.WriteLine($"O salário do funcionário é: R$ {salario} ");

static int LerNumero()
{
    int numero;

    while (true)
    {
        string data = Console.ReadLine();
        if (int.TryParse(data, out numero))
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
