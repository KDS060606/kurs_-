// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Сделать в функции, сделать проверку на отрицательность.

// int Stepen(int A, int B){
// int resault=0;
//     if ((A > 0) && (B > 0)) 
//     { 
//     resault = Convert.ToInt32(Math.Pow(A, B)); 
//     return resault; 
//     Console.WriteLine(resault); 
//     }
//     else 
//     {
//     Console.WriteLine("Отрицательные числа"); 
//     return resault; 
//     }
    

// }

// void PrintStepen(int resault)
// {
//     Console.WriteLine(resault); 
// }

// int A =int.Parse(Console.ReadLine());
// int B =int.Parse(Console.ReadLine());
// int res = Stepen(A,B);
// PrintStepen(res);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Summ(int n)
// {
// int sum=0;
// while (n>0)
//     {
//     sum = sum+n%10;
//     n/=10;
//     }
//     return sum;
// }
// void PrintSumm(int sum)
// {
//   Console.WriteLine(sum);
// }

// int namber = int.Parse(Console.ReadLine());  
// int res = Summ(namber);
// PrintSumm(res);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен
// содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр каждого числа и
// записывать их в новый массив.

// int[] FillArray(int q)
// {
//     int []array = new int [q];
//     for (int i=0; i<array.Length;i++)
//     {
//         array[i] = new Random().Next(1, 99);
//     }
//     return array;
// }

// void PrintArray(int[]array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
//     Console.Write(array[i]+" ");
//     }
// }


// int[] Suma(int[]array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
    
//         int sum=0;
//         while (array[i] > 0)
//         {
//             sum = sum + array[i]%10;
//             array[i]/=10;
//         }
//         Console.Write(sum + " ");
// }
// return array;
// }


// int q = 8;
// int []array = FillArray(q);
// PrintArray(array);
// Console.WriteLine();
// Suma(array);
// Console.WriteLine();






