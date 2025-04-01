Console.WriteLine("Digite o primeiro termo da progressão aritmética: ");
double primeiroTermo = ObterNumero();

Console.WriteLine("Digite a razão da progressão aritmética: ");
double razaoProgressao = ObterNumero();

List<double> progressao = new List<double>();

double termo = primeiroTermo;

for (int i = 0; i < 10; i++)
{
    progressao.Add(termo);
    termo += razaoProgressao;
}

double somaTermos = 0;

foreach (double valor in progressao)
{
    somaTermos += valor;
}

Console.WriteLine($"Soma entre todos os valores da sequência: {somaTermos:F1}");

Console.Write($"Sequência: ");

foreach (double valor in progressao)
{
    Console.Write($"{valor:F1} ");
}

Console.WriteLine();

double ObterNumero()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double saida))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digite novamente: ");
        }
    }
}



