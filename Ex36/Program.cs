Console.WriteLine("Quantas horas de atividade física você teve no mês?");
decimal horasMes = LerValor(1, 744);
int totalPontos = CalcularPontos(horasMes);

decimal valorGanhoNoTotal = totalPontos * 0.05m;

System.Console.WriteLine("----------------------------------------");
System.Console.WriteLine($"TOTAL DE PONTOS: {totalPontos}");
System.Console.WriteLine($"TOTAL EM DINHEIRO GANHO: {valorGanhoNoTotal:C}");
System.Console.WriteLine("----------------------------------------");

static decimal LerValor(int min, int max)
{
    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= min && valor <= max)
        {
            return valor;
        }
        else
        {
            System.Console.WriteLine("Valor inválido. Favor digitar um valor válido entre " +
            $"{min} e {max}(que é o total de horas em um mês): ");
        }
    }
}

static int CalcularPontos(decimal horas)
{
    if (horas <= 10)
    {
        return (int)horas * 2;
    }
    else if (horas <= 20)
    {
        return (int)horas * 5;
    }
    else
    {
        return (int)horas * 10;
    }
}