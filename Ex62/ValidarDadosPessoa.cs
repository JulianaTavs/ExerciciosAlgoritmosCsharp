namespace Ex62
{
    class ValidarDadosPessoa
    {
        public int ObterIdade()
        {
            Console.WriteLine("Digite sua idade: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int saida) && saida > 0 && saida <= 130)
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar uma idade válida: ");
                }
            }
        }
    }
}