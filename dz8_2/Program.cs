/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] generate2DArray(int lengthRow, int lengthCol)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int sumStringArray(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void sumStringMin(int[,] array)
{
    int count = 0;
    int minSumm = sumStringArray(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumString = sumStringArray(array, i);
        if (minSumm > sumString)
        {
            minSumm = sumString;
            count = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {count + 1} строка");
}
void printArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array = generate2DArray(3, 3);
Console.WriteLine("Задан случайный массив");
printArray(array);
sumStringMin(array);
