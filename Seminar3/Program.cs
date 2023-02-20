// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int rem, sum = 0, rev;
// {
// rev = num;
//     while (Convert.ToBoolean(num))
//         {
//             rem = num % 10;
//             num = num / 10;
//             sum = sum * 10 + rem;
//         }
//     Console.WriteLine($"The Reversed Number is: {sum} ");
//     if (rev == sum) 
//         {
//             Console.WriteLine("Number is Palindrome");
//         }
//     else
//         {
//             Console.WriteLine("Number is not a palindrome ");
//         }
// }

// --------------------------------------------------------------------------------------------------------------

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double getDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
// }

// Console.Write("Enter the x coordinate of the first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the y coordinate of the first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the z coordinate of the first point: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter the x coordinate of the second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the y coordinate of the second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the z coordinate of the second point: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Distance between points: " + Math.Round(getDistance(xa, ya, za, xb, yb, zb), 2));

// ------------------------------------------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void squareTable(int num)
// {
//     int currentNumber = 1;
//     while(currentNumber <= num)
//     {
//         Console.WriteLine(currentNumber + " - " + (currentNumber * currentNumber * currentNumber));
//         currentNumber++;
//     }

// }

// Console.Write("Enter a number: ");
// int  num = Convert.ToInt32(Console.ReadLine());
// if (num > 0)
// {
//     squareTable(num);
// }
// else
// {
//     Console.Write("Enter a number greater than 0");