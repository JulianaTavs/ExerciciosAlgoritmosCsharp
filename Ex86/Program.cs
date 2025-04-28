Console.Clear();

void Gerador()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("+-------=======------+");
    Console.WriteLine("Olá, Mundo!");
    Console.WriteLine("+-------=======------+");

    Console.ResetColor();

}

Gerador();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine();
Console.Write("Pressione qualquer tecla para sair...");
Console.ResetColor();
Console.ReadKey();

