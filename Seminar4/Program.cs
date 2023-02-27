/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

// int getSum(int a, int b)
// {
//     int sum = 1;

//     for(int i = 1; i <= b; i ++)
//     {
//         sum *= a;
//     }
//     return sum;
// }

// Console.Write("Enter a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the degree: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = getSum(a, b);
// Console.WriteLine($"Number {a} in degrees {b} amount {result}");

//------------------------------------------------------------------

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

// int NumberLen(int a)
// {
//     int count = 0;
//     for(int i = 0; a > 0; i++)
//     {
//         a /= 10;
//         count++;
//     }
//     return count;
// }

// void numSum(int num, int length)
// {
//     int sum = 0;
//     for (int i = 1; i <= length; i++)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int length = NumberLen(number);
// numSum(number, length);

//------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreatArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }

// Console.Write("Input a quantity jf elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatArray(size); 