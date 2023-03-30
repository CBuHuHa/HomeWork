using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
        }
    }
}