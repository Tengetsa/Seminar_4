// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void Task29()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
}

void FillArray(int[] construction)
{
    Random number = new Random();
    int length = construction.Length;
    for (int index = 0; index < length; index++)
    {
        construction[index] = number.Next(-99, 100);
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

Task29();

