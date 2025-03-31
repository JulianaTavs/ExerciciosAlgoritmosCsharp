using Ex68;

List<Pessoa> pessoas = new List<Pessoa>();

Console.WriteLine("Preencha as informações das oito pessoas da lista: ");
Console.WriteLine("-------------------------------------------------- ");

int contadorMulheres = 0;
int contadorHomens = 0;
double somaPesoMulheres = 0;
double maiorPesoHomens = double.MinValue;

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Cadastro da {i + 1}ª pessoa: ");
    Pessoa pessoa = new Pessoa();
    pessoas.Add(pessoa);

    if (pessoa.Genero == 'f')
    {
        contadorMulheres++;
        somaPesoMulheres += pessoa.Peso;
    }
    if (pessoa.Genero == 'm')
    {
        if (pessoa.Peso > maiorPesoHomens)
            maiorPesoHomens = pessoa.Peso;

        if (pessoa.Peso > 100)
            contadorHomens++;

    }
}

ExibirResultados();

void ExibirResultados()
{
    double media;

    Console.WriteLine("-------------------------------------------------- ");

    if (contadorMulheres > 0)
    {
        media = somaPesoMulheres / contadorMulheres;
        Console.WriteLine($"Média de peso entre as mulheres: {media:F1}");
    }
    else
    {
        Console.WriteLine("Nenhuma mulher foi cadastrada!");
    }
    Console.WriteLine($"Qtde de mulheres cadastradas: {contadorMulheres}");
    Console.WriteLine($"Qtde de homens com mais de 100kg: {contadorHomens}");

    if (contadorHomens > 0)
    {
        Console.WriteLine($"O maior peso entre os homens: {maiorPesoHomens}");
    }
    else
    {
        Console.WriteLine("Nenhum homem foi cadastrado!");
    }
}


