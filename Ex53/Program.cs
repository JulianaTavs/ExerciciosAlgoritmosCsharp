using Ex53;

Pessoa[] pessoas = new Pessoa[5];

// Preenchendo as informações das pessoas
int i = 0;
while (i < pessoas.Length)
{
    pessoas[i] = new Pessoa();
    i++;
}

// Exibindo as informações das cinco pessoas:
Console.WriteLine("---------------------------------");
int j = 0;
while (j < pessoas.Length)
{
    Console.WriteLine(pessoas[j]);
    j++;
}
Console.WriteLine("---------------------------------");

int mediaIdades = (pessoas[0].Idade + pessoas[1].Idade + pessoas[2].Idade +
pessoas[3].Idade + pessoas[4].Idade) / pessoas.Length;

Console.WriteLine($"Homens cadastrados: {Pessoa.ContadorHomem}");
Console.WriteLine($"Mulheres cadastradas: {Pessoa.ContadorMulher}");
Console.WriteLine($"Média das idades: {mediaIdades}");

if (Pessoa.ContadorHomem > 0)
{
    Console.WriteLine($"Média da idade dos homens: {Pessoa.somaIdadeHomens / Pessoa.ContadorHomem}");
}
else
{
    Console.WriteLine("Nenhum homem cadastrado, média não disponível.");
}

Console.WriteLine($"Mulheres acima dos 20 anos: {Pessoa.mulheresAcimaDeVinte}");
