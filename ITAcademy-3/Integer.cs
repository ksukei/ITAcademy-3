using System;

class Numbers
{
    static void Main()
    {
        Console.Write("Введите двухзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int tens = number / 10;
        int units = number % 10;
        int sum = tens + units;
        int product = tens * units;

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }
}