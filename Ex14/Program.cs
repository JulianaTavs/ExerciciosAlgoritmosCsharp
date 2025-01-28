Console.Clear();
Console.WriteLine("Digite a quantidade de Km percorridos pelo carro alugado: ");
float kmPercorridos = LerNumero();
Console.WriteLine("Digite a quantidade de dias pelos quais ele foi alugado: ");
int qtdeDias;

while (true)
{
    string data = Console.ReadLine()!;
    if (int.TryParse(data, out qtdeDias))
    {
        float totalAPagar = (90 * qtdeDias) + (float)(0.20 * kmPercorridos);
        Console.WriteLine($"TOTAL A PAGAR: R$ {totalAPagar:F2}");
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido! ");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Favor digite novamente a quantidade de dias pelos quais ele foi alugado: ");
        Thread.Sleep(2000);
    }
}

static float LerNumero()
{
    float numero;
    while (true)
    {
        string data = Console.ReadLine()!;
        if (float.TryParse(data, out numero))
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido! ");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Favor digite novamente a quantidade de Km percorridos pelo carro alugado: ");
            Thread.Sleep(2000);
        }
    }
}