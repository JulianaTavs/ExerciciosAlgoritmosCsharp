Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem-vindo(a) à função cronômetro.");
    Console.WriteLine("Escolha a opção desejada:");
    Console.WriteLine("1 - Setar cronômetro.");
    Console.WriteLine("2 - Sair do cronômetro.");
    string? opcao = Console.ReadLine();
    int operador = int.Parse(opcao!);

    switch (operador)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("Ex: 1m (1 minuto) / Ex2: 25s (25 segundos)");
            string? data = Console.ReadLine();
            data = data?.ToLower();
            char tipo = char.Parse(data!.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data!.Substring(0, data.Length - 1));
            int multiplier = 1;
            if (tempo == 0)
            {
                System.Environment.Exit(0);
            }
            if (tipo == 'm')
            {
                multiplier = 60;
                Start(tempo * multiplier);
            }
            Start(tempo * multiplier);
            break;
        case 2:
            System.Environment.Exit(0);
            break;
    }
}

static void Start(int tempo)
{
    int currentTime = 0;
    while (currentTime != tempo)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Cronômetro encerrado.");
    Thread.Sleep(1000);
    Console.Clear();
    Thread.Sleep(2000);
    Menu();
}
