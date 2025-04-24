double[] notas = new double[10];
double soma = 0;
int contadorAlunosAcimaDaMedia = 0;
double maiorNotaDigitada = 0;

Console.WriteLine("Entre com a nota de 10 alunos(entre 0 a 10):");

for (int i = 0; i < 10; i++)
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double saida) && saida >= 0 && saida <= 10)
        {
            notas[i] = saida;
            soma += notas[i];
            break;
        }
        else
        {
            Console.WriteLine("Digite uma nota válida");
        }
    }
}

double media = 0;

if (notas.Length > 0)
{
    media = soma / notas.Length;
    Console.WriteLine($"A média das notas é: {media:F2}");
}
else
{
    Console.WriteLine("Nenhuma nota foi inserida.");
}

foreach (var item in notas)
{
    if (item > media)
    {
        contadorAlunosAcimaDaMedia++;
    }
}

Console.WriteLine($"Tivemos {contadorAlunosAcimaDaMedia} alunos acima da média.");

foreach (var item in notas)
{
    if (item > maiorNotaDigitada)
    {
        maiorNotaDigitada = item;
    }
}

Console.WriteLine($"A maior nota digitada foi: {maiorNotaDigitada:F2}");

Console.WriteLine("Posição(ões) da maior nota digitada:");

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] == maiorNotaDigitada)
    {
        Console.Write(i + " ");
    }
}