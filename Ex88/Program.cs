void Gerador(string mensagem, int qtsVezesMostrarMensagem)
{
    Console.WriteLine("+-------=======------+");

    for (int i = 0; i < qtsVezesMostrarMensagem; i++)
    {
        Console.WriteLine(mensagem);
    }

    Console.WriteLine("+-------=======------+");
}

Gerador("Aprendendo C#", 4);