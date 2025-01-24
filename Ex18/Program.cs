Console.Clear();
// Obtém a data e hora atual
DateTime dataAtual = DateTime.Now;

// Obtém o ano da data atual
int anoAtual = dataAtual.Year;

Console.WriteLine("Digite seu ano de nascimento no seguinte formato YYYY: ");
int anoNascimento = LerNumero(anoAtual);

int idade = anoAtual - anoNascimento;
const int maiorIdade = 18;

Console.WriteLine($"Idade: {idade}");

if (idade >= maiorIdade)
{
    Console.WriteLine("Pode votar.");
}
else
{
    Console.WriteLine("Ainda não pode votar.");
}

static int LerNumero(int anoAtual)
{
    int numero;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numero) && numero <= anoAtual && numero > 0)
        {
            return numero;
        }
        else
        {
            Console.WriteLine($"Valor inválido. Favor digitar um ano válido(YYYY) que seja" +
             $" até o ano {anoAtual}(ano atual). Ex: 1989");
        }
    }
}

