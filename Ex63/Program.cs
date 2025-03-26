bool continuar = true;
int soma = 0;
int menorNumero = int.MaxValue;
int qtdeNumPares = 0;
int contador = 0;
bool algumNumeroFoiDigitado = false;

do
{
    Console.WriteLine("Digite um número:");
    int numero = ValidarNumInteiro();
    contador++;
    soma += numero;

    if (numero < menorNumero)
    {
        menorNumero = numero;
        algumNumeroFoiDigitado = true;
    }

    if (numero % 2 == 0)
    {
        qtdeNumPares++;
    }

    Console.WriteLine("Gostaria de digitar outro número? S/N");
    char prosseguir = ObterResposta();

    if (prosseguir != 's')
    {
        continuar = false;
    }

} while (continuar);

char ObterResposta()
{
    while (true)
    {
        string resposta = Console.ReadLine().Trim().ToLower();

        if (char.TryParse(resposta, out char saida) && (saida == 's' || saida == 'n'))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar S para continuar ou N para encerrar: ");
        }
    }

}

int ValidarNumInteiro()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um número válido: ");
        }
    }
}

Console.WriteLine($"Soma dos números: {soma}");

double media = 0;

if (contador == 0)
{
    Console.WriteLine("Nenhum número foi digitado, portanto não é possível calcular a média.");
}
else
{
    media = (double)soma / contador;
    Console.WriteLine($"Média dos valores: {media:F1}");

    // Exibe o menor número, mas só se algum número foi digitado:
    if (algumNumeroFoiDigitado)
    {
        Console.WriteLine($"Menor número digitado: {menorNumero}");
    }
    else
    {
        Console.WriteLine("Nenhum número foi digitado.");
    }

}

Console.WriteLine($"Qtde de valores pares: {qtdeNumPares}");
