using System.Text.RegularExpressions;

namespace Ex60
{
    class ValidarDadosPessoa
    {
        public string ValidarNome()
        {
            Console.WriteLine("Digite seu nome: ");

            while (true)
            {
                string nome = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, @"^[\p{L}\s'-]+$"))
                // O Regex acima permitirá letras, espaços, apóstrofos e hífens, o que pode 
                // ser mais adequado para nomes.
                {
                    return nome;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente o nome: ");
                }
            }
        }
        public int ValidarIdade()
        {
            Console.WriteLine("Digite sua idade: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0 && idade <= 130)
                {
                    return idade;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente sua idade: ");
                }
            }
        }
        public char ValidarGenero()
        {
            Console.WriteLine("Entre com o seu gênero. Digite M para masculino ou F para " +
            "feminino: ");

            while (true)
            {
                string genero = Console.ReadLine().Trim().ToLower();

                if (genero.Length == 1 && char.TryParse(genero, out char saida) &&
                (saida == 'm' || saida == 'f'))
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar M para masculino ou F para " +
                    "feminino: ");
                }
            }
        }
    }
}