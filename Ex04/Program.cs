
Menu();

static void Menu()
{

    Soma();
    Console.Clear();
    Continuar();
}
static void Soma()
{

    Console.Clear();
    Console.WriteLine("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine()!);
    int soma = num1 + num2;

    Console.WriteLine($"O resultado da soma dos dois números é: {soma}");
    Thread.Sleep(1000);
}
static void Continuar()
{
    int opcao;
    do
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Você gostaria de usar novamente a calculadora de somar?");
        Console.WriteLine(" 1 - SIM");
        Console.WriteLine(" 2 - NÃO. Encerrar programa.");
        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Essa opção não existe, tente novamente.");
                    Thread.Sleep(1000);
                    Continuar();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite 1 ou 2.");
            Thread.Sleep(1000);
        }
    } while (true);
}
