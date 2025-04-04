int[] vetor = new int[7];
Random random = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    int aleatorio = random.Next(0, 1001);
    vetor[i] = aleatorio;
}

Console.WriteLine(String.Join(" ", vetor));
