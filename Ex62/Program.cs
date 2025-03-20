
using Ex62;

List<Pessoa> pessoas = new List<Pessoa>();

ValidarDadosPessoa validarDados = new ValidarDadosPessoa();

int somaIdades = 0;
int pessoaAcimaDos20 = 0;

while (true)
{
    Console.WriteLine($"Adicionando a {pessoas.Count + 1}ª pessoa: ");

    Pessoa pessoa = new Pessoa(validarDados.ObterIdade());
    pessoas.Add(pessoa);

    somaIdades += pessoa.Idade;

    if (pessoa.Idade > 20)
    {
        pessoaAcimaDos20++;
    }

    Console.WriteLine("Deseja adicionar outra pessoa? S/N");
    char continuar = LerContinuar();

    if (continuar == 'n')
    {
        Console.WriteLine("Estamos encerrando o cadastro de pessoas.");
        break;
    }

}

float media = (float)somaIdades / pessoas.Count;

if (pessoas.Count > 0)
{
    Console.WriteLine($"Média das idades: {media:F1}");
}
else
{
    Console.WriteLine("Nenhuma pessoa foi cadastrada.");
}

Console.WriteLine($"Qtde de pessoas acima dos 20 anos: {pessoaAcimaDos20}");
Console.WriteLine($"Qtde de idades cadastradas: {pessoas.Count}");

static char LerContinuar()
{


    while (true)
    {
        string continuar = Console.ReadLine().Trim().ToLower();

        if (char.TryParse(continuar, out char saida) && (saida == 's' || saida == 'n'))
        {
            return saida;
        }
        else
        {
            Console.WriteLine("Valor inválido. Favor digitar S para continuar ou N" +
            " para encerrar:");
        }
    }
}
