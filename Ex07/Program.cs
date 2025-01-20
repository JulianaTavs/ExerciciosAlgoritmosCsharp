
Console.Clear();
Console.WriteLine("Digite um número com ponto flutuante: ");
double numeroConvertido = LerNumero();
double dobro = numeroConvertido * 2;
double tercaParte = numeroConvertido / 3;

Console.WriteLine($"O dobro de {numeroConvertido} é: {dobro}");
Console.WriteLine($"A terça parte de {numeroConvertido} é: {tercaParte}");

static double LerNumero()
{
    double numero;

    while (true)
    {
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out numero)) /* Se a string for convertida com sucesso para um número do
        tipo double, o loop vai ser encerrado por retornar o double para a variável numeroConvertido. */
        {
            return numero;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Número inválido. Por favor, digite um número com ponto flutuante: ");
        }
    }
}
