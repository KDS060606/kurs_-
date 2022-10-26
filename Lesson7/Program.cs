// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.


// void PrintArray (int [,]matrix)
// {
 
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray (int [,]matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,99);
//         }
    
//     }
// }
// int [,]matr = new int [3,4];
// FillArray(matr);
// PrintArray(matr);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.


// void FillArray (int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i,j]= new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray(int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchNumber(int [,]array, int x, int y)
// {
//     bool num=false;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (x<=array.GetLength(0) && y<=array.GetLength(0)) num=true;
//     }
//   } 
//   if (num==true) Console.WriteLine($"{array[x,y]}");
//   if (num==false) Console.WriteLine("Такой позиции нет в массиве");
// }

// int [,]matrix= new int [3,4];
// FillArray(matrix);
// PrintArray(matrix);


// Console.WriteLine("Введите позицию в строке массива:");
// int x=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите позицию в столбце массива:");
// int y=int.Parse(Console.ReadLine());  



// SearchNumber(matrix, x, y);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// void FillArray(double[,] array)
// {
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i,j]= new Random().Next(0,9);
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // void PrintArray(int [,]array)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write($"{array [i,j]} ");
            
// //         }
// //         Console.WriteLine();
// //     }
   
// // }

// void FillArrayAverage(double [,]array, double [] arrayAverage)
// {
  
//   int n =0;
 
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        double sum=0; 
       
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
        
//         if (n==i)
//         {
//         sum = sum + array[j,i]; 
//         arrayAverage[i]=sum;
        
//         }
       
//        }
//       n++; 
      
//       Console.Write(Math.Round(arrayAverage[i]/4,2) + " ");    
     
//     }
// }

// double [,] array=new double [4,4];
// double [] arrayAverage=new double [4];
// FillArray(array);
// Console.WriteLine();
// Console.WriteLine("Средние арефметические значения:");
// FillArrayAverage(array, arrayAverage);
// Console.WriteLine();




