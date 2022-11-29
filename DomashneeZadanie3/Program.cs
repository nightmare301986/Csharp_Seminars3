
/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int n = Prompt("Введите число N ");

int strt = 1;

int mod = n;

if (mod < 0)
{
    mod = -mod;
}
while (strt <= mod)
{
    if (n < 0)
    {

        int cube = -strt * -strt * -strt;

        System.Console.WriteLine(cube);
    }
    else
    {
        int cube = strt * strt * strt;

        System.Console.WriteLine(cube);
    }
    strt++;

}
