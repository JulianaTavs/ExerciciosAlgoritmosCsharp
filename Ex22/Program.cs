Console.Clear();
Console.WriteLine("Digite seu ano de nascimento no formato yyyy: ");
int anoNascimento = LerAno();

Console.WriteLine("Digite o mês de nascimento no formato mm: ");
int mesNascimento = LerMes();

Console.WriteLine("Digite o dia de nascimento no formato dd: ");
int diaNascimento = LerDia();

var now = DateTime.Now;
int anoAtual = now.Year;
int idade = anoAtual - anoNascimento;

// Verifica se já passou o aniversário este ano
if (now.Month < mesNascimento || (now.Month == mesNascimento && now.Day < diaNascimento))
{
    idade--; // Se ainda não fez aniversário este ano, diminui 1 da idade
}

const int maiorIdade = 18;

if (idade < maiorIdade)
{
    Console.WriteLine($"Sua idade é: {idade}. Faltam {maiorIdade - idade} anos para você se alistar.");
}
else if (idade == maiorIdade)
{
    Console.WriteLine($"Sua idade é: {idade}. Esse é o ano do seu alistamento.");
}
else
{
    Console.WriteLine($"Sua idade é: {idade}. Já fazem {idade - maiorIdade} anos que você se alistou.");
}

static int LerAno()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite seu ano de nascimento no formato yyyy:");
        }
    }
}

static int LerMes()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 12)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número válido para o mês(1-12):");
        }
    }
}

static int LerDia()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 31)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número válido para o dia(1-31):");
        }
    }
}
