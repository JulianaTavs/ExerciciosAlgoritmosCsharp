int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    if (i % 2 == 0)
    {
        vetor[i] = 5;
    }
    else
    {
        vetor[i] = 3;
    }
}

Console.WriteLine(String.Join(" ", vetor));
