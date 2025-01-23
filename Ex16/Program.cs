Console.Clear();

Console.WriteLine("Digite a quantidade de cigarros fumados por dia: ");
int qtdeCigarrosDia = LerNumero();

Console.WriteLine("Por quantos anos você já é um fumante?");
int qtdeAnos = LerNumero();

int qtdeTotalCigarros = qtdeCigarrosDia * 365 * qtdeAnos;
int tempoReduzidoEmMinutos = 10 * qtdeTotalCigarros;
int tempoReduzidoEmDias = tempoReduzidoEmMinutos / 1440;

Console.WriteLine($"Tempo reduzido de vida: {tempoReduzidoEmDias:N0} dias. I'm sad for u! :(");

static int LerNumero()
{
    int numero;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
        {
            return numero;
        }
        else
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Valor inválido.");
            Console.WriteLine("Digite novamente o valor: ");
        }
    }
}
