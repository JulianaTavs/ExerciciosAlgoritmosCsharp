Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Welcome to the Guess The Number game!");
Console.WriteLine("You'll have 4 tries to guess the number correctly.\n");

Random random = new Random();
int aleatorio = random.Next(1, 11);
int guess = 0;
int i = 1;

Console.WriteLine("Adivinhe o número! É entre 1 e 10:");
while (i <= 4)
{
    Console.WriteLine($"Tentativa {i}. Qual número você vai escolher nessa tentativa: ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Só é aceito um número entre 1 e 10. Tente novamente:");
        }
    }

    if (guess == aleatorio)
    {
        Console.WriteLine($"Você acertou! Seu número escolhido foi: {guess}");
        break;
    }
    i++;
}
Console.WriteLine();

if (guess != aleatorio)
{
    Console.WriteLine("Não foi dessa vez :/");
}

Console.WriteLine($"O número aleatório era: {aleatorio}");
Console.WriteLine("--------------------------------------------------");