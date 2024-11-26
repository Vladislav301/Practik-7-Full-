using System;
public class AbsoluteDifferenceCalculator
{
    public static int CalculateDifference(int n) => Math.Abs(n - 123) * (n > 123 ? 3 : 1);

    public static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
            Console.WriteLine($"Абсолютная разность между {number} и 123: {CalculateDifference(number)}");
        else
            Console.WriteLine("Неверный ввод.");
    }
}
