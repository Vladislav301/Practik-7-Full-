using System;
using System.Linq;

public class ArrayOperations
{
    public static void Main(string[] args)
    {
        int[] array1 = { 15, 22, 48, 11, 29, 14 };
        int[] array2 = { 37, 13, 26 };

        Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));
        Console.WriteLine("Исходный массив 2: " + string.Join(", ", array2));

        Console.WriteLine("Отсортированный массив (по возрастанию): " + string.Join(", ", array1.OrderBy(x => x)));
        Console.WriteLine("Отсортированный массив (по убыванию): " + string.Join(", ", array1.OrderByDescending(x => x)));
        Console.WriteLine("Объединенный массив: " + string.Join(", ", array1.Concat(array2).ToArray()));
    }
}
