int[] sequenciaFibonacci = new int[10];

sequenciaFibonacci[0] = 1;
sequenciaFibonacci[1] = 1;

for (int i = 2; i < sequenciaFibonacci.Length; i++)
{
    sequenciaFibonacci[i] = sequenciaFibonacci[i - 1] + sequenciaFibonacci[i - 2];
}

foreach (var item in sequenciaFibonacci)
{
    Console.Write(item + " ");
}