Console.Clear();
Console.WriteLine("Digite o valor do salário: ");
decimal salario = LerNumero();
decimal novoSalario = salario + (salario * 0.15m);
Console.WriteLine($"O salario atualizado do funcionário é: R$ {novoSalario:F2}");

static decimal LerNumero()
{
    decimal numero;

    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out numero))
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido! Por favor, digite o valor navamente.");
            Thread.Sleep(2000);
            Console.WriteLine("Digite o valor do salário: ");
        }
    }
}
