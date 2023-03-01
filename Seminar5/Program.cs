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

// int index = 0;
// for (int i = 0; i < newArray.Length; i++)
// {   
//     if (newArray[i] % 2 == 0)
//     {   
//         index++;
//     }
// }
// if (index % 10 == 1)
// {
//     Console.WriteLine($"In the array {index} even numbers");
// }
// if (index % 10 == 2 || index % 10 == 3 || index % 10 == 4)
// {
//     Console.WriteLine($"In the array {index} even numbers");
// }
// else
// {
//    Console.WriteLine($"In the array {index} even numbers");
// }
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
//     result = result + newArray[i];
// }
// Console.WriteLine($"the sum of the elements standing in odd positions = {result}");

// ------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 5;
int[] CreateRandomArray(int size)
{
    int[] array = new int[size]; 

    for (int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] newArray = CreateRandomArray(size);
ShowArray(newArray);