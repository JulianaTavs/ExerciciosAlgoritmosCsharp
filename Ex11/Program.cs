Console.Clear();
Console.WriteLine("Vamos calcular o valor de delta. Para isso: ");
Console.WriteLine("Digite o valor de a: ");
double a = LerNumero();
Console.WriteLine("Digite o valor de b: ");
double b = LerNumero();
Console.WriteLine("Digite o valor de c: ");
double c = LerNumero();

double delta = Math.Pow(b, 2) - (4 * a * c);
Console.WriteLine($"Delta vale: {delta}");

static double LerNumero()
{
    double numero;

    while (true)
    {
        string data = Console.ReadLine();
        if (double.TryParse(data, out numero))
        {
            return numero;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Valor inválido! Por favor digite o valor novamente:");
            Thread.Sleep(2000);
        }
    }
}
