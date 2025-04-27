using Ex85;

/* Enunciado: 
Faça um algoritmo que leia o nome, o sexo e o salário de 5 funcionários e
guarde esses dados em três vetores. No final, mostre uma listagem contendo
apenas os dados das funcionárias mulheres que ganham mais de R$5 mil.
*/

string[] nomes = new string[5];
char[] generos = new char[5];
decimal[] salarios = new decimal[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Informações da {i + 1}ª pessoa: ");

    Funcionario funcionario = new Funcionario();
    nomes[i] = funcionario.Nome;
    generos[i] = funcionario.Genero;
    salarios[i] = funcionario.Salario;
}

for (int j = 0; j < nomes.Length; j++)
{
    if (generos[j] == 'f' && salarios[j] > 5000)
    {
        Console.WriteLine($"Nome: {nomes[j]} - Gênero: {generos[j]} - Salário: {salarios[j]:F2}");
    }
}
