Console.WriteLine("Entre com o preço de oito produtos: ");

int contador = 1;
decimal maiorPreco = decimal.MinValue;
decimal menorPreco = decimal.MaxValue;

LerPrecos();

Console.WriteLine($"Maior preço: {maiorPreco}");
Console.WriteLine($"Menor preço: {menorPreco}");

void LerPrecos()
{
    decimal preco;

    while (contador <= 8)
    {
        if (decimal.TryParse(Console.ReadLine(), out preco))
        {
            if (preco > maiorPreco)
            {
                maiorPreco = preco;
            }
            if (preco < menorPreco)
            {
                menorPreco = preco;
            }
            contador++;
        }
        else
        {
            System.Console.WriteLine("Entre com um valor decimal para o preço. " +
            "Tente novamente para prosseguirmos: ");
        }
    }
}
