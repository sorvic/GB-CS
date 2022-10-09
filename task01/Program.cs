// в терминале:
// - провеить версию c#
// dotnet --version 
// - создание нового проекта
// dotnet new console  
// - запуск кода
// dotnet run


// Напишите программу, которая на вход принимает число
//  и выдает его квадрат (число умноженное на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

System.Console.WriteLine("Введите число >");
string inputString = Console.ReadLine();
int value = Convert.ToInt32(inputString);

int square = value*value;
System.Console.WriteLine($"Квадрат числа {value} равен {squre}");
