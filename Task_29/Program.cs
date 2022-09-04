// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] construction)
{
    int length = construction.Length;
    for (int index = 0; index < length; index++)
    {
        construction[index] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] print)
{
    int count = print.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{print[i]} ");
    }
}

int [] array = new int[8];

FillArray(array);
PrintArray(array);