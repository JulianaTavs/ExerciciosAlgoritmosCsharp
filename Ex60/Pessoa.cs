namespace Ex60
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }

        public Pessoa(string nome, int idade, char genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}; " +
                   $"Idade: {Idade}; " +
                   $"Gênero: {Genero}";
        }
    }
}