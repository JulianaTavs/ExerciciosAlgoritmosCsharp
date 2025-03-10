namespace Ex58
{
    class Aluno
    {

        public int Idade;

        public Aluno()
        {
            Idade = LerIdade();
        }

        public int LerIdade()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite novamente a idade(ou 999 para terminar): ");
                }
            }
        }

        public override string ToString()
        {
            return $"{Idade}";
        }
    }
}