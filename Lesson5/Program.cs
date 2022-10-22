// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] FillArray(int n)
// {
//     int []array = new int [n];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next(0,999);
//     }
//     return array;
// }

// void PrintArray(int []array)
// {
    
//     {
//       Console.WriteLine(String.Join(" ",array));  
//     }
    
// }

// int Poisk(int []array)
// {
//     int count=0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (array[i]%2==0) 
//         {
//             count++;  
//         }
//     }
//     Console.WriteLine(count);
//     return count;
// }

// int n=int.Parse(Console.ReadLine());
// int []array = FillArray(n);
// PrintArray(array);
// Poisk(array);

// Задача 36:Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] FillArray(int n)
// {
//     int []array = new int [n];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i]= new Random().Next(0,99);
//     }
// return array;
// }

// void PrintArray(int []array)
// {
//     Console.WriteLine(String.Join(" ",array));  
// }

// int Poisk(int []array)
// {
//     int sum=0;
//     for (int i=1; i<array.LongLength; i=i+2)
//     {
//         sum= array[i]+sum;
//     }
//     Console.WriteLine(sum);
//     return sum;
// }

// Console.WriteLine("Введите размерность массива:");
// int n=int.Parse(Console.ReadLine());
// int []array=FillArray(n);
// PrintArray(array);
// Poisk(array);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// int [] FillArray(int n)
// {
//     int []array = new int [n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array [i] = new Random().Next(0,99);
//     }
//     return array;
// }

// void PrintArray(int []array)
// {
//     Console.WriteLine(String.Join(" ", array));
// }

// void Poisk (int []array)
// {
//     int min=array[0];
//     int max=array[1];
//     int res=0;
//     for (int i = 2; i < array.Length; i++) 
//         {
//             if (array[i]>max) 
//             max=array[i];
//              if (array[i]<min)
//             min= array[i];
           
//         }    
        
        
//     Console.WriteLine($"Минимальное значение {min}, максимальное значение {max}");
//     res=max-min;
//     Console.WriteLine($"Разница между числами {res}");

            
// }

// int n = int.Parse(Console.ReadLine());
// int []array = FillArray(n);
// Poisk(array);
// PrintArray(array);








