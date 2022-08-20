// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int num3 = 0;
for (int num2 = 1; num1 > 0; num2++)
{
    num3 = num3 + num1 % 10;
    num1 = num1 / 10;
}

Console.WriteLine($"Сумма цифр в числе составит {num3}");
