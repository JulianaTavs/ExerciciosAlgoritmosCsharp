namespace Ex54
{
    public class Pessoa
    {
        public float Peso;
        public float Altura;

        public static int QtdePessoasAcimaDeNoventa;
        public static int QtdePessoasComMenosdeCinquentaKg;

        public static int QtdePessoasComMaisDeCemKg;

        public Pessoa()
        {
            Altura = LerAltura();
            Peso = LerPeso();
        }

        public float LerAltura()
        {
            while (true)
            {
                Console.WriteLine("Digite sua altura: ");
                if (float.TryParse(Console.ReadLine(), out float valor) && valor >= 0.5f && valor <= 3f)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. favor digitar novamente: ");
                }
            }
        }
        public float LerPeso()
        {
            while (true)
            {
                Console.WriteLine("Digite seu peso: ");
                if (float.TryParse(Console.ReadLine(), out float valor) && valor >= 10f && valor <= 500f)
                {
                    if (valor > 90f)
                    {
                        QtdePessoasAcimaDeNoventa++;
                    }
                    if (valor < 50f && Altura < 1.60f)
                    {
                        QtdePessoasComMenosdeCinquentaKg++;
                    }
                    if (valor > 100f && Altura > 1.90f)
                    {
                        QtdePessoasComMaisDeCemKg++;
                    }
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. favor digitar novamente: ");
                }
            }

        }
    }
}