Console.WriteLine("Digite um número inteiro: ");
int numero = LerInteiro();

Console.Write("Contagem: ");
for (int i = 0; i <= numero; i++)
{
    if (i == numero)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write($"{i}, ");
    }
}

Console.Write(", FIM!");

int LerInteiro()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("valor inválido. Favor digitar um número inteiro: ");
        }
    }
}
