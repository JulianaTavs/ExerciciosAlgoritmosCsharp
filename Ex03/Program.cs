
Console.WriteLine("Qual o seu nome?");
String? nome = Console.ReadLine();
Console.WriteLine("Qual o seu salário?");
String? salary = Console.ReadLine();
float salario = float.Parse(salary!);

Console.WriteLine($"A(O) funcionária(o) {nome} tem um salário de R$ {salario} próximo mês.");
