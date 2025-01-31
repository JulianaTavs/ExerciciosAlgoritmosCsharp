Console.Clear();

Console.WriteLine("Digite seu nome: ");
string nome = LerNome();

Console.WriteLine("Digite seu sexo: M(masculino)/ F(feminino): ");
char sexo = LerSexo();

Console.WriteLine("Digite o valor total das suas compras: ");
decimal totalCompras = LerTotalCompras();

decimal valorComDescontoMulher = totalCompras - (totalCompras * 0.13m);
decimal valorComDescontoHomem = totalCompras - (totalCompras * 0.05m);

if (sexo.Equals('F') || sexo.Equals('f'))
{
    System.Console.WriteLine($"Olá {nome}, seu total com o desconto é de: {valorComDescontoMulher:F2}");
}
else if (sexo.Equals('M') || sexo.Equals('m'))
{
    System.Console.WriteLine($"Olá {nome}, seu total com o desconto é de: {valorComDescontoHomem:F2}");
}

static string LerNome()
{
    string nome;
    while (true)
    {
        nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            System.Console.WriteLine("O campo nome não pode ser nulo ou vazio. Digite um nome: ");
        }
        else if (!nome.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
        {
            // Verifica se a string contém caracteres que não são letras ou espaços
            Console.WriteLine("O nome deve conter apenas letras e espaços. Digite seu nome novamente: ");
        }
        else
        {
            return nome.Trim();
        }
    }
}

static char LerSexo()
{
    while (true)
    {
        string input = Console.ReadLine();
        if (input.Length == 1 && (input[0] == 'M' || input[0] == 'm' || input[0] == 'F' || input[0] == 'f'))
        {
            return input[0]; // Retorna o caractere diretamente
        }
        else
        {
            Console.WriteLine("Sexo inválido. Favor digitar M para masculino ou F para feminino:");
        }
    }
}

static decimal LerTotalCompras()
{
    decimal total;
    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out total) && total > 0)
        {
            return total;
        }
        else
        {
            System.Console.WriteLine("Valor inválido. O valor precisa ser somente númerico e maior que zero."
            + " Digite novamente: ");
        }
    }
}
