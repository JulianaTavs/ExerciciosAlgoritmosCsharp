Console.Clear();

void Gerador(string mensagem)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("+-------=======------+");
    Console.WriteLine(mensagem);
    Console.WriteLine("+-------=======------+");
    Console.ResetColor();
}

Gerador("Aprendendo C# 😍");
Console.WriteLine("Digite qualquer tecla para sair...");
Console.ReadKey();