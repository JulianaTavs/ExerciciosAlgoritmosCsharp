Menu();
static void Menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Digite um número inteiro: ");
        int numero = LerNumero();

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ÍMPAR.");
        }
        Thread.Sleep(2000);
        Console.Clear();
        Continuar();
    }
}

static int LerNumero()
{
    int inteiro;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out inteiro))
        {
            return inteiro;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Valor inválido! Digite um número inteiro: ");
        }
    }
}

static void Continuar()
{
    Console.WriteLine("\nDeseja continuar?");
    Console.WriteLine("0 - SAIR");
    Console.WriteLine("1 - CONTINUAR");
    int opcao;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            switch (opcao)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Essa opção não existe. Digite 0 para SAIR ou 1 para CONTINUAR: ");
                    break;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Digite uma opção válida. Digite 0 para SAIR ou 1 para CONTINUAR: ");
        }
    }
}
