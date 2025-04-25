Random random = new Random();
int[] numerosAleatorios = new int[20];

for (int i = 0; i < numerosAleatorios.Length; i++)
{
    numerosAleatorios[i] = random.Next(0, 100);
}

foreach (var item in numerosAleatorios)
{
    Console.Write(item + " ");
}

Console.WriteLine();
Console.WriteLine("Números em ordem crescente: ");

Array.Sort(numerosAleatorios);

foreach (var item in numerosAleatorios)
{
    Console.Write(item + " ");
}


