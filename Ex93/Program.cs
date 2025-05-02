Console.WriteLine("Digite os valores de início, fim e incremento de uma contagem crescente:");

Console.Write("Início: ");
int inicio = ObterInicioValido();

Console.Write("Fim: ");
int fim = ObterFimValido();

Console.Write("Incremento: ");
int incremento = ObterIncrementoMaiorQueZero();

Contador(inicio, fim, incremento);

int ObterInicioValido()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro válido: ");
        }
    }
}

int ObterFimValido()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida) && saida > inicio)
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro"
            + " maior que o valor de início da contagem: ");
        }
    }
}

int ObterIncrementoMaiorQueZero()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida) && saida > 0)
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número inteiro maior que zero: ");
        }
    }
}

void Contador(int start, int end, int addition)
{
    List<int> contagem = new List<int>();

    for (int i = start; i <= end; i += addition)
    {
        contagem.Add(i);
    }

    for (int i = 0; i < contagem.Count; i++)
    {
        if (i <= contagem.Count - 2)
        {
            Console.Write(contagem[i] + " >> ");
        }
        else
        {
            Console.Write(contagem[i]);
        }
    }

    Console.Write(" >> FIM");
}
