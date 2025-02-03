Console.WriteLine("Digite o primeiro número inteiro: ");
int numero1 = LerNumero();
Console.WriteLine("Digite o segundo número inteiro: ");
int numero2 = LerNumero();

if (numero1 > numero2)
{
    System.Console.WriteLine($"Entre o número {numero1} e o número {numero2}, o {numero1} é o maior");
}
else if (numero2 > numero1)
{
    System.Console.WriteLine($"Entre o número {numero1} e o número {numero2}, o {numero2} é o maior");
}
else
{
    System.Console.WriteLine("Não existe valor maior, os dois são iguais.");
}

static int LerNumero()
{
    int numero;
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        System.Console.WriteLine("Valor inválido. Favor digitar um número inteiro: ");
    }
    return numero;
}
