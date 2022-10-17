// Задача 2: Напишите программу, которая на вход принимает три числа
//  и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1)
{
    if (num2 > num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}
else
{
    if (num3 > num1)
    {
        max = num3;
    }
}
System.Console.WriteLine($"{num1}, {num2}, {num3} -> max = {max}");
