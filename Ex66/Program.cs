Console.WriteLine("Digite um número inteiro entre 1 e 9:");
int numero = LerInteiro(1, 9);
int multiplicacao;

for (int i = 1; i <= 10; i++)
{
    multiplicacao = numero * i;
    Console.WriteLine($"{numero} x {i} = {multiplicacao}");
}

int LerInteiro(int min, int max)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int saida) && saida >= min && saida <= max)
        {
            return saida;
        }
        else
        {
            Console.WriteLine($"Valor inválido. Favor digitar um número dentre {min} à {max}:");
        }
    }
}
