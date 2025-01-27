Console.Clear();
Console.WriteLine("Digite seu nome:");
string? nome = Console.ReadLine();

Console.WriteLine("Digite a primeira nota(0 a 10)");
float nota1 = LerNota(0, 10);
Console.WriteLine("Digite a segunda nota(0 a 10)");
float nota2 = LerNota(0, 10);
float media = (nota1 + nota2) / 2;
Console.WriteLine($"Média da(o) {nome}: {media:F1}");

if (media > 7)
{
    Console.WriteLine($"Parabéns {nome} por seu bom aproveitamento!");
}
else
{
    Console.WriteLine($"{nome}, espero que nas próximas avaliações você tenha um melhor desempenho :)");
}

static float LerNota(float minimo, float maximo)
{
    float nota;
    while (true)
    {
        if (float.TryParse(Console.ReadLine(), out nota) && nota >= minimo && nota <= maximo)
        {
            return nota;
        }
        else
        {
            Console.WriteLine($"Valor inválido! Favor digite novamente uma nota entre " +
            $"{minimo} e {maximo}: ");
        }
    }
}