// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину матрицы: ");
int o = Convert.ToInt32(Console.ReadLine());
int [,,] array = new int [m, n, o];

Random rnd = new Random();
int [] numbers = new int [90];
int lastIndex = 89;
for (int i = 0; i < 90; i++)
{
    numbers[i] = i + 10;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {   
            int index = rnd.Next(0, lastIndex+1);
            array[i, j, k] = numbers[index];
            numbers[index] = numbers[lastIndex];
            lastIndex--;
            Console.Write($"{array[i, j, k]} ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = array[i, j, k];
            Console.Write($"{array[i, j, k]} ");
            Console.Write($"({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}