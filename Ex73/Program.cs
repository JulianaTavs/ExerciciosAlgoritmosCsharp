int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = i;
}

/* Console.Write(String.Join(" ", vetor)); => Só a título de curiosidade. Fixando a questão da imutabilidade
das strings. O String.Join cria uma nova string a cada execução, sem modificar o vetor original, o que reforça o
conceito de que strings não podem ser alteradas diretamente. Isso é uma característica importante em C#.*/

Console.Write(String.Join(" ", vetor.Reverse()));
