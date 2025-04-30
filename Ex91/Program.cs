Console.WriteLine("Digite dois números inteiros: ");

Console.Write("1º número: ");
int num1 = ObterInteiroValido();

Console.Write("2º número: ");
int num2 = ObterInteiroValido();

Maior(num1, num2);

int ObterInteiroValido()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro: ");
        }
    }
}

static void Maior(int numero1, int numero2)
{
    if (numero1 > numero2)
    {
        Console.WriteLine($"Maior número: {numero1}");
    }
    else if (numero2 > numero1)
    {
        Console.WriteLine($"Maior número: {numero2}");
    }
    else
    {
        Console.WriteLine("Os números são iguais. ");
    }
}
