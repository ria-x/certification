
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// void PrintNumbers(int start, int end)
// {
//     if (start <= 0)
//     {
//         Console.Write("Вы вводите не натуральное число");
//         return;
//     }

//     {
//         if (start > end)
//         {
//             Console.Write("Конечное число меньше начального");
//             return;
//         }

//         PrintNumbers(start + 1, end);

//         Console.WriteLine(start);
//     }
// }
// int M = 2;
// int N = 8;
// PrintNumbers(M, N);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


// static int akkerman(int x, int y)
// {

//     if (x == 0)
//     {
//         return (y + 1);
//     }
//     else if (y == 0)
//     {
//         return (akkerman(x - 1, 1));
//     }
//     else
//     {
//         return (akkerman(x - 1, akkerman(x, y - 1)));
//     }

// }

// int m = 1;
// int n = 7;
// Console.WriteLine(akkerman(m, n));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


void PrintArray(int[] Array, int index)
{
    if ((index < Array.Length) && (index >= 0))
    {
        Console.WriteLine(Array[index]);
        PrintArray(Array, index - 1);
    }
}
int[] Array = { 34, 12, 5, 7 };
PrintArray(Array, Array.Length - 1);


