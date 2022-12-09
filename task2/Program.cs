// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Clear();

void PrintArray(int[,] arg)
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

void FillArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(0, 10);
        }
    }
}
void SearchPosishion(int[,] arg, int rows, int colums) 
{
    if (arg.GetLength(0) > rows && arg.GetLength(1) > colums)
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                if (i == rows && j == colums)
                {
                    Console.WriteLine($"На строке массива {rows} и столбце массива {colums} элемент {arg[i, j]}");
                }
            }

        }
    }
    else
    {
        Console.WriteLine("Такой позиции в массиве нет");

    }
}

Console.Write("Введите длину строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию в длине строки: ");
int posRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в длине столбца: ");
int posColums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[rows, colums];

FillArray(arr);
PrintArray(arr);
SearchPosishion(arr, posRows, posColums);