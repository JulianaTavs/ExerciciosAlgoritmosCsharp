using System.Globalization;

CalculadoraDeConversao();
static void CalculadoraDeConversao()
{
    Console.Clear();
    Console.WriteLine("Digite o valor em R$ que você deseja converter para dólar: ");
    decimal valor = LerNumero();

    decimal ValorEmDolar = valor / 6.03m;
    Console.WriteLine($"A conversão de R${valor} para dólar fica {ValorEmDolar.ToString("C",
        CultureInfo.CreateSpecificCulture("en-US"))}");
}
static decimal LerNumero()
{
    decimal numero;

    while (true)
    {

        if (decimal.TryParse(Console.ReadLine(), out numero))
        {
            return numero;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
            Thread.Sleep(2000);
            Console.WriteLine("Digite o valor que você deseja converter para dólar:");
        }
    }
}
