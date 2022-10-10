/*
// Задача №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//int num = new Random().Next(10000, 99999);
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num);
int resault2 = (num / 1000);
int resault1 = (num % 100);

Console.WriteLine(resault1);
Console.WriteLine(resault2);
if (resault1 == resault2)
    Console.WriteLine("полидром");
else 
    Console.WriteLine("не полидром");
    

    // Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int x1;
int y1;
int z1;
int x2;
int y2;
int z2;

    Console.WriteLine("Введите х1:");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y1:");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z1:");
    z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите х2:");
    x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y2:");
    y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z2:");
    z2 = Convert.ToInt32(Console.ReadLine());
    double otvet = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    Console.WriteLine("Расстояние между точками:" +otvet);


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



int q = int.Parse(Console.ReadLine());
int [] a = new int[q];
void FillArray(int length, int [] col)
{
int index = 0;
    while(index<length)
    {
    col[index]=new Random().Next(0,100);
    index ++;
    }
}
void PrintArray(int[]coll)
{
    int count = coll.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(coll[position]+" ");
        position++;
    }
}


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);

*/