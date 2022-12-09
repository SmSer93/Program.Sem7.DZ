// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

void PrintArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(0, 10);
        }
    }
}

void AverageArray(double[,] arg)
{
    double c = 0; // Вспомогательные переменные
    double b = 0; //
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            c = c + arg[i, j];
        }
        b = 0;
        b = c / arg.GetLength(0);
        c = 0;
        Console.WriteLine(Math. Round(b,2));
    }
}




Console.Write("Введите длину строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[rows, colums];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
AverageArray(arr);


