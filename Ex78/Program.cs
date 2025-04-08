int[] numeros = new int[15];
Console.WriteLine("Digite 15 números: ");

for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            numeros[i] = saida;
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar novamente um número: ");
        }
    }
}

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i]);
    if (i < numeros.Length - 1)
        Console.Write(" ");
}

Console.WriteLine(" ");
Console.Write("Múltiplos de 10: ");

List<int> multiplos = new List<int>();

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 10 == 0)
    {
        multiplos.Add(numeros[i]);
    }
}

foreach (var item in multiplos)
{
    Console.Write(item);
    if (multiplos.IndexOf(item) < multiplos.Count - 1)
    {
        Console.Write(" ");
    }
}