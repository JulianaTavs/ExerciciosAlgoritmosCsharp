CalculadoraDeConversao();
static void CalculadoraDeConversao()
{
    Console.Clear();
    Console.WriteLine("Digite o valor em R$ que você deseja converter para dólar: ");
    float valor = LerNumero();

    float ValorEmDolar = valor / 6.03f;
    Console.WriteLine($"A conversão de R${valor} em dólar fica U${ValorEmDolar:F2}");
}
static float LerNumero()
{
    float numero;

    while (true)
    {
        string data = Console.ReadLine()!;

        if (float.TryParse(data, out numero))
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
