using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string digits = new string(input.Where(char.IsDigit).ToArray());
        Console.WriteLine($"Цифры в строке: {digits}");
    }
}
