Console.WriteLine("Digite o tamanho do primeiro segmento de reta:");
double a = LerNumero();

Console.WriteLine("Digite o tamanho do segundo segmento de reta:");
double b = LerNumero();

Console.WriteLine("Digite o tamanho do terceiro segmento de reta:");
double c = LerNumero();

if (a < b + c && b < a + c && c < a + b)
{
    Console.Write("É um triângulo ");
    if (a == b && b == c)
    {
        Console.Write("EQUILÁTERO.");
    }
    else if (a == b || b == c || c == a)
    {
        Console.WriteLine("ISÓSCELES.");
    }
    else
    {
        Console.WriteLine("ESCALENO.");
    }
}
else
{
    Console.WriteLine("Não é um triângulo.");
}

static double LerNumero()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double numero) && numero > 0)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número positivo: ");
        }

    }
}