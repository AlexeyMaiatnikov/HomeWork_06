/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using static System.Console;
Clear();
WriteLine("Введите числа через пробел: ");
string[] InArr = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Количество положительных чисел: {PositiveCount(InArr)}");



int PositiveCount(string[] InArr)
{
    int numb = 0;
    int count = 0;
    for (int i = 0; i < InArr.Length; i++)
    {
        if (!int.TryParse((InArr[i]), out numb))
        {

            Environment.Exit(0);
        }
        else
        {
            count += numb > 0 ? 1 : 0;
        }
    }


    return count;
}