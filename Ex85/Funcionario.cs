using System.Text.RegularExpressions;

namespace Ex85
{
    class Funcionario
    {
        public string Nome { get; set; }
        public char Genero { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {
            Nome = LerNome();
            Genero = LerGenero();
            Salario = LerSalario();
        }

        public string LerNome()
        {
            Console.WriteLine("Digite seu nome: ");

            string nome;

            while (true)
            {
                nome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, "^[\\p{L}\\s]+$"))
                {
                    return nome;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar um nome válido: ");
                }
            }
        }

        public char LerGenero()
        {
            Console.WriteLine("Digite seu gênero (M/F): ");

            while (true)
            {
                string genero = Console.ReadLine().Trim().ToLower();

                if (char.TryParse(genero, out char saida) && (saida == 'm' || saida == 'f'))
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar M para sexo masculino" +
                    " ou F para sexo feminino: ");
                }
            }
        }

        public decimal LerSalario()
        {
            Console.WriteLine("Digite seu salário: ");

            while (true)
            {

                if (decimal.TryParse(Console.ReadLine(), out decimal saida) && saida > 0)
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar um salário válido acima de zero: ");
                }
            }
        }
    }
}