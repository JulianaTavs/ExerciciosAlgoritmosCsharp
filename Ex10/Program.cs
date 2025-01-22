Console.Clear();
Console.WriteLine("Digite a largura da parede em metro: ");
float largura = LerNumero();
Console.WriteLine("Digite a altura da parede em metro: ");
float altura = LerNumero();
float area = largura * altura;
float qtdeTinta = area / 2;
Console.WriteLine(" ");
Console.WriteLine($"Para pintar os {area} m² é necessário {qtdeTinta:F2} litros de tinta.");

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
            Console.WriteLine("Valor inválido. Por favor digite o número novamente em metro: ");
            Thread.Sleep(2000);
        }
    }
}
