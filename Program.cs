/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя" +name);

Задача №1

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
    Console.WriteLine(number1);
else
    Console.WriteLine(number2);

Задачаа №2

int max = 0; 
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
if ((number1 > number2) && (number1 > number3))
max = number1;
else if  ((number2 > number1) && (number2 > number3))
max = number2;
else if  ((number3 > number1) && (number3 > number2))
max = number3;
Console.WriteLine(max);

Задача №3
 Console.Write("Введите число: ");
 int number = int.Parse(Console.ReadLine());
 if (number % 2 ==0)
    Console.WriteLine("делится на 2 без остатка");
 else 
     Console.WriteLine("не делится на 2 без остатка");

Задача №4

 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());
 int i = 0;
  for (i=2; i<num; i+=2) 
{
    Console.WriteLine(i);
}
*/