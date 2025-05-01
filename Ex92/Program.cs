Console.WriteLine("Digite um número inteiro: ");
int num = ObterInteiroValido();

ParOuImpar(num);

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

static void ParOuImpar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par.");
    }
    else
    {
        Console.WriteLine($"O número {numero} é ímpar.");
    }
}
