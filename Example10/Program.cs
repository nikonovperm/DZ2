// Напишите программу которая принимает на вход трехзначное число и выходе показывает вторую цифру этого числа
int GetSecondLetterOfNumber(int letter)
{
    letter = letter / 10 % 10;
    return letter;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int letter = GetSecondLetterOfNumber(number);
Console.WriteLine("Вторая цифра числа: " + letter);
