/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using static System.Console;
Clear();
Write("Ведите коэффициенты b1 и k1 первой прямой через пробел: ");
Point Y1 = GetCoefficientFromString(ReadLine()!);
Write("Ведите коэффициенты b2 и k2 второй прямой через пробел: ");
Point Y2 = GetCoefficientFromString(ReadLine()!);


if (Y1.k == Y2.k && Y1.b == Y2.b)
{
    WriteLine("Пересечений нет, прямые одинаковы");
}
else if (Y1.k == Y2.k)
{
    WriteLine("Пересечений нет, прямые параллельны ");
}
else
{
    double x = ((Y2.b - Y1.b) / (Y1.k - Y2.k));
    double y = (Y1.k * ((Y2.b - Y1.b) / (Y1.k - Y2.k)) + Y1.b);

    WriteLine($"Точка пересечения имеет координаты x= {x}, y= {y}");
}






//WriteLine($"[{String.Join(",", FillArray())}]");

/*double FillArray()
{
    double[] inArray = new double[2];
    for (int i = 0; i < 2; i++)
    {

        inArray[0] = ((Y2.b - Y1.b) / (Y1.k - Y2.k));
        inArray[1] = (Y1.k * ((Y2.b - Y1.b) / (Y1.k - Y2.k)) + Y1.b);

    }
    return inArray;


}
*/


Point GetCoefficientFromString(string inStr)
{
    Point res = new Point();
    string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.b = double.Parse(par[0]);
    res.k = double.Parse(par[1]);
    return res;
}

struct Point
{
    public double b;
    public double k;
}
