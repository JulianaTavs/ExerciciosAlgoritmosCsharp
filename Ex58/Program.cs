using System.Globalization;
using Ex58;

List<Aluno> alunos = new List<Aluno>();

int contador = 0;
int somaIdades = 0;

while (true)
{
    Console.WriteLine($"Entre a idade do aluno {contador + 1}(ou 999 para terminar):");
    Aluno aluno = new Aluno();

    if (aluno.Idade == 999)
        break;

    alunos.Add(aluno);
    contador++;
    somaIdades += aluno.Idade;
}

Console.WriteLine("-------------------------------------------------");

double mediaIdades;
if (contador > 0)
{
    mediaIdades = (double)somaIdades / contador;
    Console.WriteLine($"Média das idades: {mediaIdades.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Qtde de alunos: {contador}");
}
else
{
    Console.WriteLine("Nenhum aluno cadastrado!");
}

int i = 1;

alunos.ForEach(item =>
{
    Console.WriteLine($"Idade do aluno {i}: {item}");
    i++;
});


