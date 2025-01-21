Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("Digite a distância a percorrer em metros:");
    double distancia = LerNumero();
    double km = distancia / 1000;
    double hm = distancia / 100;
    double dam = distancia / 10;
    double dm = distancia * 10;
    double cm = distancia * 100;
    double mm = distancia * 1000;

    Console.WriteLine($"A distância de {distancia} metros corresponde a:");
    Console.WriteLine($"{km} km");
    Console.WriteLine($"{hm} Hm");
    Console.WriteLine($"{dam} Dam");
    Console.WriteLine($"{dm} dm");
    Console.WriteLine($"{cm} cm");
    Console.WriteLine($"{mm} mm");
}

static double LerNumero()
{
    double distancia;

    while (true)
    {
        string data = Console.ReadLine();
        if (double.TryParse(data, out distancia))
        {
            return distancia;
        }
        else
        {
            Console.WriteLine("Número inválido. Favor digitar um valor válido: ");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Digite a distância a percorrer em metros:");


        }
    }

}