// Задача 4: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    if (count % 2 == 0)
    {
        System.Console.WriteLine($"{num} -> {count}");
    }
    count = count + 1;
}

// КОММЕНТ от преподавателя:
// лучше так:
// int count = 2;

// while (count <= num)
// {
//     System.Console.WriteLine($"{num} -> {count}");
//     count = count + 2;
// }
