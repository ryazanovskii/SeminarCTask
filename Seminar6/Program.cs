// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Enter the number of numbers to enter: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int positiveCount = 0;

// for (int i = 0; i < size; i++)
// {
//     Console.Write($"Input a number {i+1}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 0) positiveCount++;
//         else if (num < 0)
//         {
//         Console.WriteLine("Negative numbers are not supported.");
//         i--;
//         }
// }
// Console.WriteLine($"You have entered {positiveCount} positive numbers.");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Enter the b1 coordinate of the first point: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the b2 coordinate of the first point: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter the k1 coordinate of the second point: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the k2 coordinate of the second point: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Intersection at a point: ({x};{y})");