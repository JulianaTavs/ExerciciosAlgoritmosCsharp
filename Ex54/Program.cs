using Ex54;

int i = 0;

Pessoa[] pessoas = new Pessoa[7];

while (i < pessoas.Length)
{
    pessoas[i] = new Pessoa();
    i++;
}

float somaAltura = 0;
int j = 0;
while (j < pessoas.Length)
{
    somaAltura += pessoas[j].Altura;
    j++;
}
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine($"Média das alturas do grupo: {somaAltura / pessoas.Length:F2} m");
Console.WriteLine($"Quantidade de pessoas acima de 90 KG: {Pessoa.QtdePessoasAcimaDeNoventa}");
Console.WriteLine("Quantidade de pessoas que pesam menos de 50Kg e tem menos" +
$" de 1.60m: {Pessoa.QtdePessoasComMenosdeCinquentaKg}");
Console.WriteLine("Quantidade de pessoas que medem mais de 1.90m e pesam" +
 $" mais de 100Kg: {Pessoa.QtdePessoasComMaisDeCemKg}");
Console.WriteLine("-------------------------------------------------------------------------");