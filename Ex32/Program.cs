Console.WriteLine("Bem-vinda(o)!");
Console.WriteLine("Nesse jogo de adivinhação, o computador vai sortear um número " +
"entre 1 e 5. Você vai tentar acertar que número foi o sorteado.");
Random numero = new Random();

/* O computador vai sortear um número entre 1 e 5. O jogador vai tentar descobrir 
qual foi o valor sorteado. */
do
{
    int numeroAleatorio = numero.Next(1, 6);

    Console.WriteLine("Entre com o seu palpite: (1-5)");

    int palpite = LerNumero(1, 5);

    Console.WriteLine($"O número sorteado foi: {numeroAleatorio}");
    Console.WriteLine($"O seu palpite foi: {palpite}");

    if (numeroAleatorio == palpite)
    {
        Console.WriteLine("Você acertou!!");
    }
    else
    {
        Console.WriteLine("Não foi dessa vez :(");
    }
    Console.WriteLine("Deseja jogar novamente? (s/n)");

} while (Console.ReadLine()?.ToLower() == "s");

Console.WriteLine("Obrigado por jogar! Até a próxima!");

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
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro entre 1 e 5: ");
        }
    }
}


