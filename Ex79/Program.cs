int[] numeros = new int[10];

Console.WriteLine("Digite 10 números inteiros: ");

for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write($"Digite o número {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            numeros[i] = saida;
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro: ");
        }
    }
}

Console.WriteLine("\nNúmeros pares e suas posições:");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine($"Posição de armazenamento: {i} | Número digitado: {numeros[i]}");
    }
}