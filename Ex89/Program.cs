Console.WriteLine("Borda 1: +-------=======------+");
Console.WriteLine("Borda 2: ~~~~~~~~:::::::~~~~~~~");
Console.WriteLine("Borda 3: <<<<<<<<------->>>>>>>");
Console.WriteLine();

Gerador("Aprendendo C#!", 3, 3);
Console.WriteLine("Aperte qualquer tecla para sair...");
Console.ReadKey();

static void TipoDeBorda(int borda)
{
    switch (borda)
    {
        case 1:
            Console.WriteLine("+-------=======------+");
            break;
        case 2:
            Console.WriteLine("~~~~~~~~:::::::~~~~~~~");
            break;
        case 3:
            Console.WriteLine("<<<<<<<<------->>>>>>>");
            break;
        default:
            Console.WriteLine("Borda não disponível.");
            break;
    }
}

static void Gerador(string mensagem, int vezesQueAMensagemAparece, int tipoDeBorda)
{
    TipoDeBorda(tipoDeBorda);

    for (int i = 0; i < vezesQueAMensagemAparece; i++)
    {
        Console.WriteLine(mensagem);
    }

    TipoDeBorda(tipoDeBorda);
}

