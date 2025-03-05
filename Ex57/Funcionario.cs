namespace Ex57
{
    class Funcionario
    {
        public decimal salario;
        public char sexo;
        public static decimal salarioTotalHomens = 0;
        public static decimal salarioTotalMulheres = 0;

        public Funcionario()
        {
            salario = LerSalario();
            sexo = LerSexo();
        }

        public decimal LerSalario()
        {
            Console.WriteLine("Entre com o seu salário: ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente seu salário: ");
                }
            }
        }
        public char LerSexo()
        {
            Console.WriteLine("Entre com o seu gênero. Digite m para MASCULINO " +
            "ou f para FEMININO: ");
            string sexo = Console.ReadLine().ToLower();

            while (true)
            {
                if (char.TryParse(sexo, out char saida) && (saida == 'm' || saida == 'f'))
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente seu gênero: ");
                }
            }
        }
        public char DesejaContinuar()
        {
            Console.WriteLine("Deseja cadastrar um novo funcionário? S/N");
            string continuar = Console.ReadLine().ToLower();

            while (true)
            {
                if (char.TryParse(continuar, out char valor) && (valor == 's' || valor == 'n'))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite s para CONTINUAR ou n para ENCERRAR:");
                }
            }
        }
    }
}