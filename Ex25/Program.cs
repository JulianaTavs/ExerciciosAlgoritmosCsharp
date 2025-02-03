Console.WriteLine("Digite o valor do primeiro segmento de reta: ");
double a = LerSegmento();
Console.WriteLine("Digite o valor do segundo segmento de reta: ");
double b = LerSegmento();
Console.WriteLine("Digite o valor do terceiro segmento de reta: ");
double c = LerSegmento();

if ((a + b) > c && (a + c) > b && (b + c) > a)
{
    System.Console.WriteLine("É possível formar um triângulo com esses três segmentos de reta.");
}
else
{
    System.Console.WriteLine("Não é possível formar um triângulo com esses três segmentos de reta.");
}


static double LerSegmento()
{
    while (true)
    {
        string entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada) && double.TryParse(entrada, out double valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número positivo: ");
        }
    }
}
