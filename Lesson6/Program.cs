// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// var spisok=new List <int>(5);

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Введите число:");
//     int n=int.Parse(Console.ReadLine());
//     spisok.Add(n);
// }

// int col=0;
// foreach (var item in spisok)
// {
    
//     if (item>0) col++;
   
// }
// Console.WriteLine($"Вы ввыели {col} чисел больше нуля");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения для формулы линии: y = k1 * x + b1 ");
Console.Write("k1 =  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 =  ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y = k2 * x + b2");
Console.Write("k2 =  ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 =  ");
double b2 = double.Parse(Console.ReadLine());
void DrawIntersection (double k1, double b1, double k2, double b2) // если координаты пересечения дробные, то не отмечает точку пересечения =(
{
k1 = (int)k1; b1 = (int)b1; k2 = (int)k2; b2 = (int)b2;
for (int i = -7; i < 7; i++)
{
    for (int j = -50; j < 50; j++)
    {
        if (j == k1 * i + b1 && j == k2 * i + b2) Console.Write("!");
        if (j == k1 * i + b1 || j == k2 * i + b2) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}
}
void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1-k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения {x} , {y}");
}
DrawIntersection (k1, b1, k2, b2);
Intersection(k1, b1, k2, b2);