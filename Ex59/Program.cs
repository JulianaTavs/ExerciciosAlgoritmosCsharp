using System.Globalization;
using Ex59;

PessoaValidacaoDados pessoaValidacao = new PessoaValidacaoDados();

List<Pessoa> pessoas = new List<Pessoa>();

int contadorHomens = 0;
int mulherMaisJovem = int.MaxValue;
double sumIdadeHomens = 0;

int i = 1;
while (true)
{
    Console.WriteLine($"Entre com os dados da {i}ª pessoa: ");
    char genero = pessoaValidacao.ValidarGenero();
    int idade = pessoaValidacao.ValidarIdade();

    Pessoa pessoa = new Pessoa(genero, idade);
    pessoas.Add(pessoa);

    if (pessoa.Genero == 'm')
    {
        contadorHomens++;
        sumIdadeHomens += pessoa.Idade;
    }
    else if (pessoa.Idade < mulherMaisJovem)
    {
        mulherMaisJovem = pessoa.Idade;
    }

    Console.WriteLine("Deseja adicionar uma nova pessoa? Digite 1 (para sim) ou 2 (para não): ");
    int continuar;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida) && (saida == 1 || saida == 2))
        {
            continuar = saida;
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida. Opções: Digite 1 (para sim) ou 2 (para não):");
        }
    }

    if (continuar == 2)
    {
        break;
    }
    i++;
}

int maiorIdade = int.MinValue;
i = 1;
foreach (var item in pessoas)
{
    if (maiorIdade < item.Idade)
    {
        maiorIdade = item.Idade;
    }
    Console.WriteLine($"Dados da {i}ª pessoa: ");
    Console.WriteLine(item);
    Console.WriteLine();
    i++;
}

double mediaIdadesHomens = contadorHomens > 0 ? sumIdadeHomens / contadorHomens : 0;

Console.WriteLine($"Maior idade lida: {maiorIdade} anos.");
Console.WriteLine($"Qtde de homens cadastrados: {contadorHomens}");
Console.WriteLine($"Idade da mulher mais jovem: {mulherMaisJovem} ano(s).");
Console.WriteLine($"Média de idade entre os homens: {mediaIdadesHomens.ToString
("F2", CultureInfo.InvariantCulture)}");