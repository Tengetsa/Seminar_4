// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень: ");
int degree = int.Parse(Console.ReadLine()!);

int getSumNumber(int numA)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result *= number; 
    }
    return result;                                                                                
}

Console.WriteLine($"{number}^{degree} = {getSumNumber(number)}");


