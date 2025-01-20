Console.WriteLine("Digite a primeira nota: ");
float nota1 = LerNumero();
Console.WriteLine("Digite a segunda nota: ");
float nota2 = LerNumero();
float media = (nota1 + nota2) / 2;
Console.WriteLine($"A média entre {nota1} e {nota2} é igual a {media}");

static float LerNumero()
{
    float numero;
    while (true)
    {
        string entrada = Console.ReadLine();
        if (float.TryParse(entrada, out numero))  // Verifica se a entrada é um número válido
        {
            return numero;  // Retorna a entrada se for um número válido
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite uma nota válida:");
        }
    }
}