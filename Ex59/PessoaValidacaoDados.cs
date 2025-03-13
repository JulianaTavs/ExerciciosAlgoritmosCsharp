namespace Ex59
{
    class PessoaValidacaoDados
    {
        public char ValidarGenero()
        {
            Console.WriteLine("Digite seu gênero. F para feminino ou M para masculino: ");
            while (true)
            {
                string genero = Console.ReadLine().Trim().ToLower();
                if (char.TryParse(genero, out char saida) && (saida == 'm' || saida == 'f'))
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar F para sexo feminino ou " +
                    "M para sexo masculino:");
                }
            }
        }
        public int ValidarIdade()
        {
            Console.WriteLine("Digite sua idade: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int saida) && saida > 0 && saida < 130)
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