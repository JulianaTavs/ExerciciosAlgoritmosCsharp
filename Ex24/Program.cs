Console.WriteLine("Qual a distância que você deseja percorrer em Km?");
double distancia = LerDistancia();
double precoPassagem;

if (distancia <= 200)
{
    precoPassagem = 0.50 * distancia;// Tarifa de 0.50 por km para distâncias até 200 km
}
else
{
    precoPassagem = 0.45 * distancia;// Tarifa de 0.45 por km para distâncias acima de 200 km
}
Console.WriteLine($"Valor da passagem: {precoPassagem.ToString("C")}");

static double LerDistancia()
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite uma quilometragem maior do que zero: ");
        }
    }
}
