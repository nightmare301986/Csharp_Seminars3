/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Не использовать строки
14212 -> нет
12821 -> да
23432 -> да */

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}


bool ValidateNumber(int number)
{
    if (number >= 10000 && number < 100000)
    {
        return true;
    }

    System.Console.WriteLine("Число не пятизначное");
    return false;
}

int number = Prompt("Введите число:");

if (ValidateNumber(number))
{
    int numb1 = (number / 1000) * 10; //Первый шаг для числа 1
    int numb2 = number - (numb1 * 100); //Первый шаг для числа 2

    int numb3 = numb1 / 10; //Второй шаг для числа 1
    int numb4 = numb2 - (numb2 / 100) * 100; //Второй шаг для числа 2

    int numb5 = numb3 - (numb3 / 10) * 10; //Третий шаг для числа 1
    int numb6 = numb4 / 10; //Третий шаг для числа 2

    int numb7 = numb3 / 10; //Четвертый шаг для числа 1
    int numb8 = numb4 - (numb4 / 10) * 10; //Четвертый шаг для числа 2

    if (numb5 == numb6 & numb7 == numb8) //Вывод является ли число палиндромом или нет
    {
        System.Console.WriteLine("Число " + number + " является палиндромом");
    }

    else
    {
        System.Console.WriteLine("Число " + number + " не палиндром");
    }
}