Console.Clear();
Console.WriteLine("Digite a velocidade do carro (km/h): ");
int velocidade = LerNumero();
int velocidadeExcedente;
decimal valorMulta;

if (velocidade > 80)
{
    Console.WriteLine("Usuário multado!");
    velocidadeExcedente = velocidade - 80;
    valorMulta = velocidadeExcedente * 5;
    Console.WriteLine($"Você excedeu a velocidade em {velocidadeExcedente} km/h");
    Console.WriteLine($"Valor da multa: R$ {valorMulta:F2}");
}
else
{
    Console.WriteLine("Dentro da velocidade permitida.");
}

static int LerNumero()
{
    int numero;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um valor válido: ");
        }
    }
}



