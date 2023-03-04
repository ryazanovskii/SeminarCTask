// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int rows, int colums)
// {
//     double[,] array = new double[rows, colums];
//     {
//         Random rand = new Random();
//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < colums; j++)
//                     array[i,j] = Math.Round(rand.Next(-100,100) * 0.1, 1);
//             }
//         return array;
//     }
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter the b1 coordinate of the first point: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the b2 coordinate of the first point: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = CreateRandom2dArray(rows, colums);
// Show2dArray(newArray);

// -----------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 \ 7 -> элемента с такими индексами в массиве нет

// int rows = 4;
// int colums = 4; 
// double[,] CreateRandom2dArray(int rows, int colums)
// {
//     double[,] array = new double[rows, colums];
//     {
//         Random rand = new Random();
//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < colums; j++)
//                     array[i,j] = Math.Round(rand.Next(-100,100) * 0.1, 1);
//             }
//         return array;
//     }
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] newArray = CreateRandom2dArray(rows, colums);
// Show2dArray(newArray);

// Console.Write("Input a index x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a index y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x < newArray.GetLength(0) && y < newArray.GetLength(1)) Console.WriteLine(newArray[x, y]);
// else Console.WriteLine($"{x}{y} -> there is no element with such indexes in the array");

// -----------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int rows = 4;
// int colums = 4; 
// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];
//     {    
//         Random random = new Random();
//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < colums; j++)
//                     array[i, j] = random.Next(100);
//             }
//         return array;
//     }
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] newArray = CreateRandom2dArray(rows, colums);
// Show2dArray(newArray);

// double[] arithmeticMean = new double[newArray.GetLength(1)];
// for (int j = 0; j < newArray.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         sum += newArray[i, j];
//     }
//    arithmeticMean[j] = sum / newArray.GetLength(0);

// }

// Console.WriteLine("Meaning:");
// for (int j = 0; j < newArray.GetLength(1); j++)
// {
//     Console.WriteLine($"Column {j}: {arithmeticMean[j]}");
// }