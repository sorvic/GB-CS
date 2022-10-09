// Задача 1: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

System.Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine($"max = {num1}, min = {num2}");
}
else
{
    System.Console.WriteLine($"max = {num2}, min = {num1}");
}
