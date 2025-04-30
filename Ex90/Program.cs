Console.WriteLine("Digite dois números inteiros: ");

Console.Write("1º: ");
int num1 = ValidarInteiro();

Console.Write("2º: ");
int num2 = ValidarInteiro();

Somador(num1, num2);

int ValidarInteiro()
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

static void Somador(int numero1, int numero2)
{
    int sum = numero1 + numero2;
    Console.WriteLine($"Soma dos dois números: {sum}");
}