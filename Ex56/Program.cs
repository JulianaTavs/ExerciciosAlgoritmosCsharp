using System.Globalization;

double flag = 0;
double somatorio = 0;

while (flag != 1111)
{
    Console.WriteLine("Digite um número(Digite 1111 para encerrar): ");

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out flag))
        {
            break;
        }
        else
        {
            Console.WriteLine(" Valor inválido. Só são aceitos números. Tente novamente: ");
        }
    }

    if (flag != 1111)
        somatorio += flag;
}

Console.WriteLine("-------------------------------------------- ");
Console.Write("Flag ativada!");
Console.WriteLine($" Somatório: {somatorio.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine("再见!");
