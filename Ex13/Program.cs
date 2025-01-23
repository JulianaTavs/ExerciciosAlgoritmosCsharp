Console.WriteLine("Digite o valor do salário: ");
float salario = LerNumero();
float novoSalario = salario + (float)(salario * 0.15);
Console.WriteLine($"O salario atualizado do funcionário é: R$ {novoSalario}");

static float LerNumero()
{
    float numero;

    while (true)
    {
        string data = Console.ReadLine();
        if (float.TryParse(data, out numero))
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
