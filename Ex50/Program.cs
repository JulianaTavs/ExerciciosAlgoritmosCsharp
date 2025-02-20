Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Vamos sortear 20 números: ");

int contador = 1;
int numero;
Random numeroAleatorio = new Random();
int numerosAcimaDeCinco = 0;
int numerosDivisiveisPorTres = 0;

Console.WriteLine(" ");
Console.Write("Números sorteados: ");

while (contador <= 20)
{
    numero = numeroAleatorio.Next(0, 11);
    Console.Write(numero + " ");

    if (numero % 3 == 0)
    {
        numerosDivisiveisPorTres++;
    }

    if (numero > 5)
    {
        numerosAcimaDeCinco++;
    }
    contador++;
}

Console.WriteLine("");
Console.WriteLine($"Qtde de números acima de 5: {numerosAcimaDeCinco} ");
Console.WriteLine($"Qtde de números divisíveis por 3: {numerosDivisiveisPorTres} ");
Console.WriteLine("----------------------------------------------------------------");