Console.WriteLine("Digite sete números inteiros: ");

int contador = 1;
int numero;
int soma = 0;

while (contador <= 7)
{
    numero = int.Parse(Console.ReadLine());
    soma += numero;
    contador++;
}

Console.WriteLine($"Somatório: {soma}");
