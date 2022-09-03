// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

void sumNumber(int sum)
{
    int result = 0;
    while (sum != 0)
    {
        result += sum % 10;
        sum = sum / 10;
    }
    Console.WriteLine(result);
}

sumNumber(number);