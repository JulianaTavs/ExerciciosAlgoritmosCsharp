namespace Ex68
{
    class Pessoa
    {
        public char Genero;
        public double Peso;

        public Pessoa()
        {
            Genero = ObterGenero();
            Peso = ObterPeso();
        }

        char ObterGenero()
        {
            Console.WriteLine("Entre com seu gênero: F/M");

            while (true)
            {
                string genero = Console.ReadLine().ToLower();

                if (char.TryParse(genero, out char saida) && (saida == 'f' || saida == 'm'))
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Favor digitar um gênero válido. F para feminino ou M para masculino: ");
                }
            }
        }

        double ObterPeso()
        {
            Console.WriteLine("Entre com seu peso: ");

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double saida) && saida > 0)
                {
                    return saida;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar novamente seu peso: ");
                }
            }
        }
    }
}


