// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2"); 
Console.Write("b1 = "); 
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
bool PositionLines(double b1, double k1, double b2, double k2)
{
    if (k1==k2)
    {
        if (b1==b2)
        {
        Console.Write("Прямые совпадают");
        return false;
        }
        else 
        {
        Console.Write("Прямые параллельны");
        return false;
        }
    }
    return true;
}
if (PositionLines(b1, k1, b2, k2))
{
double y = (k1*b2 - k2*b1)/(k1 - k2);
double x = (y-b1)/k1;
Console.Write($"Точка пересечения двух прямых -> ({x};{y})");
}