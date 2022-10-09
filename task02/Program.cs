// 1. Напишите программу, которая на вход принимает два числа
//  и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите первое число: "); // выводим фразу
string inputStringOne = Console.ReadLine(); // Считываем с экрана значение
int valueOne = Convert.ToInt32(inputStringOne); // переводиим строку
System.Console.WriteLine("Введите второе число: ");
int valueTwo = int.Parse(Console.ReadLine()); // считыввем строку с экрана и сразу конфертируем в число

if (valueTwo == valueOne*valueOne)
{
    System.Console.WriteLine($"Число {valueTwo} является квадратом числа {valueOne}");
}
else
{
    System.Console.WriteLine($"Число {valueTwo} не вляется квадратом числа {valueOne}");
}
