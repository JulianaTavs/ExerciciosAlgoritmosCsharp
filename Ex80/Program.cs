int[] numeros = new int[30];
Random random = new Random();

Console.Clear();

Console.Write("30 números sorteados entre 1 e 15: ");

for (int i = 0; i < numeros.Length; i++)
{
    int aleatorio = random.Next(1, 16);
    numeros[i] = aleatorio;
}

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i]);
    if (i < numeros.Length - 1)
    {
        Console.Write(" ");
    }
}

Console.WriteLine();
Console.WriteLine();
Console.Write("Digite um número inteiro entre 1 e 15: ");

int digitadoPeloUsuario;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out int saida) && saida >= 1 && saida <= 15)
    {
        digitadoPeloUsuario = saida;
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido. Favor digitar um número inteiro entre 1 e 15: ");
    }
}

Console.WriteLine("Posições em que o número digitado foi encontrado: ");

int contador = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == digitadoPeloUsuario)
    {
        Console.Write(i + " ");
        contador++;
    }
}

Console.WriteLine();
Console.WriteLine($"Qtde de vezes que o número foi sorteado: {contador}");
Console.WriteLine("Fim do programa! Pressione qualquer tecla para sair...");
Console.ReadKey();






