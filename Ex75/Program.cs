int[] vetor = new int[15];

vetor[0] = 1;
vetor[1] = 1;

for (int i = 2; i < vetor.Length; i++)
{
    vetor[i] = vetor[i - 1] + vetor[i - 2];
}

Console.WriteLine(String.Join(" ", vetor));
