Console.Clear();
Console.WriteLine("Digite um ano para saber se ele é ou não um ano bissexto: ");
Console.WriteLine("PS: O ano deve ser informado no formato AAAA (por exemplo, 2023)," +
"representando os quatro dígitos do ano: ");
int ano = LerAno();
bool EhBissexto = DateTime.IsLeapYear(ano);

if (EhBissexto)
{
    Console.WriteLine($"O ano {ano} é BISSEXTO.");
}
else
{
    Console.WriteLine($"O ano {ano} não é BISSEXTO.");
}



static int LerAno()
{
    int numero;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero > 0)
            {
                return numero;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O ano deve ser um número positivo: ");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um ano válido no formato yyyy: ");
        }
    }
}
