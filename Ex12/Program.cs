Console.Clear();
Console.WriteLine("Digite o preço do produto para calcular o seu desconto: ");
decimal preco = LerNumero();
decimal desconto = preco * 0.05m;
decimal valorPromocional = preco - desconto;

Console.WriteLine($"PREÇO PROMOCIONAL: R$ {valorPromocional:F2}");

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
            Console.WriteLine("Valor inválido! Digite o valor novamente.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Digite o preço do produto para calcular o seu desconto:");
        }
    }
}
