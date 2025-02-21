Console.WriteLine("Entre com a idade de 10 pessoas: ");

int maiorIdadeLida = int.MinValue;
int maisQueDezoito = 0;
int menosQueCinco = 0;
float somaDasIdades = 0;
int contador = 1;

LerIdades();

void LerIdades()
{
    while (contador < 11)
    {
        if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0)
        {
            if (idade > maiorIdadeLida)
            {
                maiorIdadeLida = idade;
            }

            if (idade > 18)
            {
                maisQueDezoito++;
            }

            if (idade < 5)
            {
                menosQueCinco++;
            }

            somaDasIdades += idade;
            contador++;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número positivo para a idade: ");
        }
    }
    Console.WriteLine($"Média de idade do grupo: {somaDasIdades / 10}");
    Console.WriteLine($"Pessoas com mais de 18 anos: {maisQueDezoito}");
    Console.WriteLine($"Pessoas com menos de 5 anos: {menosQueCinco}");
    Console.WriteLine($"Maior idade lida: {maiorIdadeLida}");
}
