using System;
using System.Linq;

class program
{
    public static void Main()
    {
        int[] array = { 1, 0, 0, -545, 3, -4, 12, 105, 0, 2, 12 };
        var posNums = from n in array
            where n > 0
            select n;
        var negNums = from n in array
            where n < 0
            select n;
        var notnullNums = from n in array
            where n != 0
            select n;
        var evenNums = from n in array
            where n % 2 == 0
            select n;
        int pr = 1;
        foreach (int num in notnullNums)
        {
            pr *= num;
        }
        Console.WriteLine($"Кол-во положительных {posNums.Count()}");
        Console.WriteLine($"Кол-во отрицательных {negNums.Count()}");
        Console.WriteLine($"Произведение ненулевых {pr}");
        Console.WriteLine($"Сумма чётных {evenNums.Sum()}");
    }
}