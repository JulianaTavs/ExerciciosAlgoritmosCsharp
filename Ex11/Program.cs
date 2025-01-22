Console.Clear();
Console.WriteLine("Vamos calcular o valor de delta. Para isso: ");
Console.WriteLine("Digite o valor de a: ");
float a = LerNumero();
Console.WriteLine("Digite o valor de b: ");
float b = LerNumero();
Console.WriteLine("Digite o valor de c: ");
float c = LerNumero();

float delta = (b * b) - (4 * a * c);
Console.WriteLine($"Delta vale: {delta}");

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
            Console.Clear();
            Console.WriteLine("Valor inválido! Por favor digite o valor novamente:");
            Thread.Sleep(2000);
        }
    }
}
