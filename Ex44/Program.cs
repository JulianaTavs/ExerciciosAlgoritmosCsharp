int inicioContagem;
int fimContagem;

do
{
    Console.WriteLine("De qual número você deseja que a contagem seja iniciada: ");
    inicioContagem = LerInteiro();

    Console.WriteLine("Até qual número você deseja que a contagem vá: ");
    fimContagem = LerInteiro();

    if (inicioContagem >= fimContagem)
    {
        Console.WriteLine("O número final deve ser maior que o número inicial. Tente novamente: ");
    }
} while (fimContagem <= inicioContagem);

Console.WriteLine("De quanto em quanto você deseja que a contagem incremente: ");
int incremento = LerIncremento();

while (inicioContagem <= fimContagem)
{
    Console.Write(inicioContagem + " ");
    inicioContagem += incremento;
}

Console.Write("Acabou!");

static int LerInteiro()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro: ");
        }
    }
}

static int LerIncremento()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro positivo: ");
        }
    }
}