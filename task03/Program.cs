// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
//  5 -> Пятница

System.Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    System.Console.WriteLine("День недели ПН");
}
else if (day == 2)
{
    System.Console.WriteLine("День недели ВТ");
}
else if (day == 3)
{
    System.Console.WriteLine("День недели СР");
}
else if (day == 4)
{
    System.Console.WriteLine("День недели ЧТ");
}
else if (day == 5)
{
    System.Console.WriteLine("День недели ПТ");
}
else if (day == 6)
{
    System.Console.WriteLine("День недели СБ");
}
else if (day == 6)
{
    System.Console.WriteLine("День недели ВСК");
}
else if (day < 1 || day >7)
{
    System.Console.WriteLine("Такого дня недели не существует");
}

switch(day) // решение через свитч - выбор через значение
{
    case 1: System.Console.WriteLine("ПН");
    break;
    case 2: System.Console.WriteLine("ВТ");
    break;
    case 3: System.Console.WriteLine("СР");
    break;
    case 4: System.Console.WriteLine("ЧТ");
    break;
    case 5: System.Console.WriteLine("ПТ");
    break;
    case 6: System.Console.WriteLine("СБ");
    break;
    case 7: System.Console.WriteLine("ВСК");
    break;
}
