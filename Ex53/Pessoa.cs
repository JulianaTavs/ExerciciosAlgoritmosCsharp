using System.Text.RegularExpressions;

namespace Ex53
{
    public class Pessoa
    {
        public int Idade;
        public int Genero;
        public string Nome = " ";
        public static int ContadorHomem = 0;
        public static int ContadorMulher = 0;
        public static double somaIdadeHomens = 0;
        public static double mulheresAcimaDeVinte = 0;

        public Pessoa()
        {
            Idade = LerIdade();   // Primeiro, lê e define a idade
            Genero = LerGenero(); // Depois, lê e define o gênero
            Nome = LerNome();     // Por fim, lê e define o nome
        }

        public int LerIdade()
        {
            System.Console.WriteLine("Qual a sua idade: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0)
                {
                    return idade;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente a idade: ");
                }
            }
        }

        public int LerGenero()
        {
            System.Console.WriteLine("Qual o seu gênero: ");
            while (true)
            {
                Console.WriteLine("Digite 1 para FEMININO ou 2 para MASCULINO:");
                if (int.TryParse(Console.ReadLine(), out int genero) && (genero == 1 ||
                genero == 2))
                {
                    if (genero == 1)
                    {
                        if (Idade > 20)
                            mulheresAcimaDeVinte++;

                        ContadorMulher++;
                    }
                    else
                    {
                        somaIdadeHomens += Idade;
                        ContadorHomem++;
                    }
                    return genero;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente: ");
                }
            }
        }

        public string LerNome()
        {
            Console.WriteLine("Qual o seu nome: ");
            string nome;
            while (true)
            {
                nome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, "^[\\p{L}\\s]+$"))
                //O regex acomoda nomes com acentos ou caracteres de alfabetos diferentes (como ç, é, etc.)
                {
                    return nome;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente o nome: ");
                }
            }
        }

        public string ObterGeneroPorExtenso()
        {
            return Genero == 1 ? "Feminino" : "Masculino";
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "; " +
                   "Idade: " + Idade + "; " +
                   "Gênero: " + ObterGeneroPorExtenso();
        }
    }
}