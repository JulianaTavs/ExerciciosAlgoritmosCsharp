int[] vetor = new int[10];
int soma = 0;

for (int i = 0; i < vetor.Length; i++)
{
    soma += 5;
    vetor[i] = soma;
}

foreach (var item in vetor)
{
    Console.Write(item + " ");
}

// Ou usar isso para a impressão do vetor: Console.WriteLine(string.Join(" ", vetor));
