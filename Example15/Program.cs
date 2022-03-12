// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void weekdayWeekend (int dayOfTheWeek)
{   switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Будний день");
        break;
    case 2:
        Console.WriteLine("Будний день");
        break;
    case 3:
        Console.WriteLine("Будний день");
        break;
    case 4:
        Console.WriteLine("Будний день");
        break;
    case 5:
        Console.WriteLine("Будний день");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("ERROR");
        break;
}
}

Console.WriteLine("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
weekdayWeekend (number);
