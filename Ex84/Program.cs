using System.Text.RegularExpressions;

string[] nomes = new string[9];
int[] idades = new int[9];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o nome da pessoa {i + 1}: ");
    while (true)
    {
        string nome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, "^[\\p{L}\\s]+$"))
        {
            nomes[i] = nome;
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar um nome válido: ");
        }
    }

    Console.WriteLine("Digite sua idade: ");

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida))
        {
            idades[i] = saida;
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar novamente sua idade: ");
        }
    }
}

const int MAIOR_IDADE = 18;
int contadorMenoresDeIdade = 0;

for (int j = 0; j < idades.Length; j++)
{
    if (idades[j] < MAIOR_IDADE)
    {
        Console.WriteLine($"Nome: {nomes[j]} Idade: {idades[j]}");
        contadorMenoresDeIdade++;
    }
}

if (contadorMenoresDeIdade == 0)
{
    Console.WriteLine("Nenhum menor de idade foi cadastrado!");
}

