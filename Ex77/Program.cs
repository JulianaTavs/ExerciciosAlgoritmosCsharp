using System.Text.RegularExpressions;

string[] nomes = new string[7];

Console.WriteLine("Digite o nome de sete pessoas:");

for (int i = 0; i < nomes.Length; i++)
{
    while (true)
    {
        string nome = Console.ReadLine().Trim();
        if (!string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, @"^[\p{L}\s'-]+$"))
        {
            nomes[i] = nome;
            break;
        }
        else
        {
            Console.WriteLine("O nome inserido é inválido. Digite novamente: ");
        }
    }
}

Console.Write("Nomes na ordem inversa: ");
for (int i = nomes.Length - 1; i >= 0; i--)
{
    Console.Write(nomes[i]);
    if (i > 0)
        Console.Write(" ");
}

Console.WriteLine();

