// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result  > 9999)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не пятизначное число. Повторите ввод");
        }
    }

    return result;
}

void PalindromNumber(int number)
{
    string str = Convert.ToString(number);

    if (str[0]==str[4] && str[1]==str[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

int number = GetNumber("Введите пятизначное число: ");
PalindromNumber (number);
