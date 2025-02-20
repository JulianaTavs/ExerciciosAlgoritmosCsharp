Console.WriteLine("Entre com seis números inteiros:");
int pares = 0;
int impares = 0;

LerInteiros();

Console.WriteLine($"Qtde de números pares: {pares}");
Console.WriteLine($"Qtde de números ímpares: {impares}");

void LerInteiros()
{
    int contador = 1;
    int numero;

    while (contador <= 6)
    {
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            contador++;
        }
        else
        {
            Console.WriteLine("Valor inválido. Só são aceitos números inteiros. " +
            "Favor digitar um número inteiro para prosseguirmos:");
        }

    }
}