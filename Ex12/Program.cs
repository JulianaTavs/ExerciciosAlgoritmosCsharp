Console.Clear();
Console.WriteLine("Digite o preço do produto para calcular o seu desconto: ");
float preco = LerNumero();
float desconto = (float)(preco * 0.05);
float valorPromocional = preco - desconto;

Console.WriteLine($"PREÇO PROMOCIONAL: R$ {valorPromocional}");

static float LerNumero()
{
    float numero;

    while (true)
    {
        string data = Console.ReadLine();
        if (float.TryParse(data, out numero))
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
