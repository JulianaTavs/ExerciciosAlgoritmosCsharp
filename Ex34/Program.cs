Console.WriteLine("Digite sua altura(em metros): ");
double altura = LerValor();

Console.WriteLine("Digite seu peso(em kg):");
double peso = LerValor();

double imc = peso / Math.Pow(altura, 2);
Console.WriteLine("------------------------------");
Console.WriteLine($"Seu IMC é: {imc:F1}.");
Console.Write("Classificação: ");

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso.");
}
else if (imc < 25)
{
    Console.WriteLine("Peso ideal.");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso.");
}
else if (imc <= 40)
{
    Console.WriteLine("Obesidade.");
}
else
{
    Console.WriteLine("Obesidade mórbida.");
}
Console.WriteLine("------------------------------");
static double LerValor()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Digite um valor válido: ");
        }
    }
}