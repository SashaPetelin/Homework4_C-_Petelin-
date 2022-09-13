Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Сумма цифр в числе: ");
Console.WriteLine(GetSum(number));

int GetSum(int number)
{
    int sum = 0;
    while (number >= 1)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}