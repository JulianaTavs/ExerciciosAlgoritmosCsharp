Console.WriteLine("Digite a idade de 8 pessoas: ");

int[] idades = new int[8];
int soma = 0;
int maiorIdade = 0;
for (int i = 0; i < 8; i++)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            idades[i] = saida;
            soma += saida;
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. favor digitar a idade novamente: ");
        }
    }
}

double media = (double)soma / idades.Length;
Console.WriteLine($"A média de idades é: {media:F2}");

Console.Write("Posição(ões) em que temos pessoas com idades maior que 25: ");
for (int i = 0; i < idades.Length; i++)
{
    if (idades[i] > 25)
    {
        Console.Write(i + " ");
    }
    if (idades[i] > maiorIdade)
    {
        maiorIdade = idades[i];
    }
}

Console.WriteLine();
Console.WriteLine($"A maior idade é: {maiorIdade}");

Console.Write("Posição(ões) em que a maior idade foi digitada: ");
for (int i = 0; i < idades.Length; i++)
{
    if (idades[i] == maiorIdade)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine();
Console.WriteLine("Fim do programa.");
Console.WriteLine("Aperte qualquer tecla para encerrar o programa.");
Console.ReadKey();