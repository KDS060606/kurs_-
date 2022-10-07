/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 999);
Console.WriteLine(num);
int resault = (num / 100) * 10 + num % 10;
Console.WriteLine(resault);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = int.Parse(Console.ReadLine());
int resault = 0;
if (num>99) 
resault = num % 10;
if (num>999)  
resault = (num % 100)/10;
Console.WriteLine(resault);
if (num < 100) Console.WriteLine("Нет третьего числа");


//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int num = int.Parse(Console.ReadLine());
if (num==6) Console.WriteLine("Выходной");
if (num==7) Console.WriteLine("Выходной");
if ((num!=6) && (num!=7)) Console.WriteLine("Не выходной");

*/


