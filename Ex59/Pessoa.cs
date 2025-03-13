namespace Ex59
{
    class Pessoa
    {
        public char Genero { get; set; }
        public int Idade { get; set; }

        public Pessoa(char genero, int idade)
        {
            Genero = genero;
            Idade = idade;
        }
        public override string ToString()
        {
            return $"Gênero: {Genero}\n" +
                   $"Idade: {Idade}";
        }
    }
}