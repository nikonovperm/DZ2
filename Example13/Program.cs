// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void GetThirdLetterOfNumber (int number)
{
    if (number < 100)
    {
        Console.Write("Третьей цифры нет");      
    }
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.Write("Третья цифра числа: " + number);
    }
}    

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetThirdLetterOfNumber(number);
