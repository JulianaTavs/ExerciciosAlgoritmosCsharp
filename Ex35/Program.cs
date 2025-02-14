System.Console.WriteLine("Entre com a quantidade de dias de aluguel do veículo:");
int quantidadeDias = LerInteiro();

System.Console.WriteLine("Quantos quilometros foram percorridos?");
double quilometrosRodados = LerValor();

decimal valorAPagar = 0;
int escolha;
do
{
    Console.WriteLine("Qual tipo de carro você alugou?");
    System.Console.WriteLine("1 - Carro popular");
    System.Console.WriteLine("2 - Carro de luxo");
    escolha = LerInteiro();

    if (escolha != 1 && escolha != 2)
    {
        Console.WriteLine("Opção inválida! Por favor, escolha entre 1 ou 2.");
    }
} while (escolha != 1 && escolha != 2);

switch (escolha)
{
    case 1:
        if (quilometrosRodados <= 100)
        {
            valorAPagar = (decimal)quantidadeDias * 90 + (decimal)quilometrosRodados * 0.20m;
        }
        else
        {
            valorAPagar = (decimal)quantidadeDias * 90 + (decimal)quilometrosRodados * 0.10m;
        }
        break;
    case 2:
        if (quilometrosRodados <= 200)
        {
            valorAPagar = (decimal)quantidadeDias * 150 + (decimal)quilometrosRodados * 0.30m;
        }
        else
        {
            valorAPagar = (decimal)quantidadeDias * 150 + (decimal)quilometrosRodados * 0.25m;
        }
        break;
}

System.Console.WriteLine($"TOTAL A PAGAR: {valorAPagar:C}");

static int LerInteiro()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            return numero;
        }
        else
        {
            System.Console.WriteLine("Digite um número inteiro válido: ");
        }
    }
}

static double LerValor()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double valor))
        {
            return valor;
        }
        else
        {
            System.Console.WriteLine("Favor digitar um valor válido: ");
        }
    }
}

