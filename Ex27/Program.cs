Console.WriteLine("Digite a primeira nota: ");
float nota1 = LerNota();
Console.WriteLine("Digite a segunda nota: ");
float nota2 = LerNota();

float media = (nota1 + nota2) / 2;

if (media <= 4.9)
{
    System.Console.WriteLine($"Média: {media:F1}. Aluno reprovado por média baixa.");
}
else if (media <= 6.9)
{
    System.Console.WriteLine($"Média: {media:F1}. Aluno em recuperação.");
}
else
{
    System.Console.WriteLine($"Média: {media:F1}. Aluno aprovado.");
}

static float LerNota()
{
    float nota;
    while (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
    {
        System.Console.WriteLine("Valor inválido. Favor digitar uma nota válida entre 0 e 10: ");
    }
    return nota;
}

