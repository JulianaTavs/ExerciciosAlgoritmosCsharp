Console.Clear();
Console.WriteLine("Digite um número inteiro: ");
int numero = LerNumero();
int antecessor;
int sucessor;

antecessor = numero - 1;
sucessor = numero + 1;

Console.WriteLine($"O antecessor de {numero} é {antecessor}.");
Console.WriteLine($"O sucessor de {numero} é {sucessor}.");

static int LerNumero()
{
    int numero;


    while (true)
    {
        string entrada = Console.ReadLine()!;
        if (int.TryParse(entrada, out numero))
        {
            return numero;
        }
        else
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Digite um número válido: ");
        }
    }
}