Console.WriteLine("Qual o valor da casa?");
decimal valorCasa = LerValorDecimal();

Console.WriteLine("Qual o salário do comprador?");
decimal salarioComprador = LerValorDecimal();

Console.WriteLine("Em quantos anos você pretende pagar o imóvel?");
int qtdeAnos = LerQtdeAnosDePagamento();

decimal prestacaoMensal = valorCasa / (qtdeAnos * 12);

if (prestacaoMensal > (salarioComprador * 0.3m))
{
    Console.WriteLine("Parcela mensal excede a 30% do salário do comprador: Empréstimo negado.");
}
else
{
    Console.WriteLine(" Empréstimo concedido! ");
}

static decimal LerValorDecimal()
{
    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar o valor novamente: ");
        }
    }
}

static int LerQtdeAnosDePagamento()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar novamente em quantos anos"
            + " você pretende pagar o imóvel: ");
        }
    }
}
