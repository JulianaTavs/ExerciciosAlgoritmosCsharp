// JoKenPo
//A PEDRA vence a TESOURA
//A TESOURA vence o PAPEL
//O PAPEL vence a PEDRA

Console.WriteLine("Escolha entre Pedra, papel ou tesoura:");
Console.WriteLine("1 - PEDRA");
Console.WriteLine("2 - PAPEL");
Console.WriteLine("3 - TESOURA");

int escolhaDoUsuario = LerNumero(1, 3);

Random numeroAleatorio = new Random();
int escolhaDoComputador = numeroAleatorio.Next(1, 4);

Console.WriteLine($"Escolha do computador: {LerEscolhaDoComputador(escolhaDoComputador)}");

if (escolhaDoComputador == escolhaDoUsuario)
{
    Console.WriteLine("Empate!");
}
else if (escolhaDoComputador == 1 && escolhaDoUsuario == 3 ||
         escolhaDoComputador == 3 && escolhaDoUsuario == 2 ||
         escolhaDoComputador == 2 && escolhaDoUsuario == 1)
{
    Console.WriteLine("Você perdeu!");
}
else
{
    Console.WriteLine("Você ganhou!");
}

static int LerNumero(int min, int max)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= min && numero <= max)
        {
            return numero;
        }
        else
        {
            Console.WriteLine($"Valor inválido. Favor digitar um número válido({min}-{max}): ");
        }
    }
}

static string LerEscolhaDoComputador(int escolha)
{
    switch (escolha)
    {
        case 1:
            return "PEDRA";
        case 2:
            return "PAPEL";
        case 3:
            return "TESOURA";
        default:
            return "Escolha inválida";
    }
}
