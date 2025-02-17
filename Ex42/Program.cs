Console.WriteLine("Digite um número inteiro e positivo qualquer: ");
int numero = LerNumero();

int i = 1;

Console.WriteLine("---------------------------");
while (i <= numero)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine("Acabou!");
Console.WriteLine("---------------------------");

static int LerNumero()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            System.Console.WriteLine("Entrada inválida. Favor digitar um número inteiro positivo: ");
        }
    }
}
