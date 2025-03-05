using Ex57;

Console.WriteLine("Programa de cadastro de funcionários.");

Funcionario[] funcionario = new Funcionario[30];

char continuar = 's';

int i = 0;

while (continuar == 's' && i < funcionario.Length)
{
    // Criando uma nova instância de Funcionario para o index atual:
    funcionario[i] = new Funcionario();

    if (funcionario[i].sexo == 'f')
    {
        Funcionario.salarioTotalMulheres += funcionario[i].salario;
    }
    else
    {
        Funcionario.salarioTotalHomens += funcionario[i].salario;
    }

    continuar = funcionario[i].DesejaContinuar();
    i++;
}

Console.WriteLine($"Total de salários pagos aos homens: {Funcionario.salarioTotalHomens}");
Console.WriteLine($"Total de salários pagos às mulheres: {Funcionario.salarioTotalMulheres}");