// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size]; 

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// -------------------------------------------------------------

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size]; 

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {   
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("input a quntity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int count = 0;
// for (int i = 0; i < newArray.Length; i++)
// {   
//     if (newArray[i] % 2 == 0) count++;
// }
// if (count % 10 == 1) Console.WriteLine($"In the array {count} even numbers");

// else Console.WriteLine($"In the array {count} even numbers");

// -------------------------------------------------------------

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = 5;
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size]; 

//     for (int i = 0; i < size; i ++)
//     {
//         array[i] = new Random().Next(-100, 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int result = 0;
// for(int i = 1; i < size; i+=2)
// {   
//     result += newArray[i];
// }
// Console.WriteLine($"the sum of the elements standing in odd positions = {result}");

// ------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int size = 5;
// double[] CreateRandomArray(int size)
// {
//     double[] array = new double[size];
//     {
//         Random rand = new Random();
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = Math.Round(rand.Next(0,100) * 0.1, 1);
//             }
//         return array;
//     }
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// double[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// double difference = 0;
// double maxValue = newArray[0];
// double minValue = newArray[0];
// for (int i = 0; i < newArray.Length; i++)
// {
//     if (maxValue < newArray[i]) maxValue = newArray[i];
//     if (minValue > newArray[i]) minValue = newArray[i];
// }
// difference += maxValue - minValue;
// Console.WriteLine($"Difference maximum {maxValue} and minimum {minValue} numbers = {difference}");

// ------------------------------------------------------------------------------------------------