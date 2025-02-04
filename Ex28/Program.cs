Console.WriteLine("Digite a largura do terreno:");
double largura = LerValor();

Console.WriteLine("Digite o comprimento do terreno:");
double comprimento = LerValor();

double area = largura * comprimento;
System.Console.WriteLine($"ÁREA: {area:F2} m²");

if (area < 100)
{
    System.Console.WriteLine("Classificação do terreno: TERRENO POPULAR");
}
else if (area <= 500)
{
    System.Console.WriteLine("Classificação do terreno: TERRENO MASTER");
}
else
{
    System.Console.WriteLine("Classificação do terreno: TERRENO VIP");
}

static double LerValor()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            System.Console.WriteLine("Valor inválido. Favor digitar um número positivo: ");
        }
    }
}
