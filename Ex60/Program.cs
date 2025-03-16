using System.Globalization;
using Ex60;

List<Pessoa> pessoas = new List<Pessoa>();

ValidarDadosPessoa validarDados = new ValidarDadosPessoa();

int i = 1;
int idadePessoaMaisVelha = int.MinValue;
int idadeMulherMaisJovem = int.MaxValue;

while (true)
{
    Console.WriteLine($"Entre com os dados da {i}ª pessoa: ");

    string nome = validarDados.ValidarNome();
    int idade = validarDados.ValidarIdade();
    char genero = validarDados.ValidarGenero();

    Pessoa pessoa = new Pessoa(nome, idade, genero);

    pessoas.Add(pessoa);

    Console.WriteLine("Deseja adicionar uma nova pessoa? S/N");
    string continuar;
    while (true)
    {
        continuar = Console.ReadLine().Trim().ToLower();

        if (!string.IsNullOrWhiteSpace(continuar) && continuar[0] == 'n' || continuar[0] == 's')
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar S para continuar ou N para encerrar: ");
        }
    }

    if (continuar[0] == 'n')
    {
        break;
    }
    i++;
}
string nomePessoaMaisVelha = "";
string nomeMulherMaisJovem = "";
int somaIdades = 0;
int homensAcimaDos30 = 0;
int mulheresAbaixoDos18 = 0;

foreach (var item in pessoas)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------------------------------");

foreach (var item in pessoas)
{
    if (item.Idade > idadePessoaMaisVelha)
    {
        idadePessoaMaisVelha = item.Idade;
        nomePessoaMaisVelha = item.Nome;
    }

    if (item.Genero == 'f')
    {
        if (item.Idade < idadeMulherMaisJovem)
        {
            idadeMulherMaisJovem = item.Idade;
            nomeMulherMaisJovem = item.Nome;
        }
    }
    else if (item.Genero == 'm' && item.Idade > 30)
    {
        homensAcimaDos30++;
    }

    if (item.Genero == 'f' && item.Idade < 18)
    {
        mulheresAbaixoDos18++;
    }

    somaIdades += item.Idade;
}

double mediaIdades = (double)somaIdades / pessoas.Count;

Console.WriteLine($"Nome da pessoa mais velha: {nomePessoaMaisVelha}");
Console.WriteLine($"Nome da mulher mais jovem: {nomeMulherMaisJovem}");
Console.WriteLine($"Média das idades do grupo: {mediaIdades.ToString("F2",
CultureInfo.InvariantCulture)}");
Console.WriteLine($"Homens com mais de 30 anos: {homensAcimaDos30}");
Console.WriteLine($"Mulheres com menos de 18 anos: {mulheresAbaixoDos18}");