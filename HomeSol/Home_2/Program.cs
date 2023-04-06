using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task_1();
            Task_2();
            Task_3();
            Task_4();

        }

        public static void Task_1()
        {
            Console.Write("operand1: ");
            int operand1 = int.Parse(Console.ReadLine());

            Console.Write("operand2: ");
            int operand2 = int.Parse(Console.ReadLine());

            Console.Write("sign: ");
            string sign = Console.ReadLine();

            double result = 0;

            switch (sign)
            {
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("DivideByZeroException");
                    }
                    else
                    {
                        result = operand1 / operand2;
                        Console.WriteLine(result);
                    }
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine(result);
                    break;
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine(result);
                    break;
            }

        }

        public static void Task_2()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case >= 0 and <= 14:
                    Console.WriteLine("[0 - 14]");
                    break;
                case >= 15 and <= 35:
                    Console.WriteLine("[15 - 35]");
                    break;
                case >= 36 and <= 50:
                    Console.WriteLine("[36 - 50]");
                    break;
                case >= 51 and <= 100:
                    Console.WriteLine("[50 - 100]");
                    break;
                default:
                    Console.WriteLine("out of range");
                    break;
            }
        }

        public static void Task_3()
        {
            Console.Write("Word to translate: ");
            string word = Console.ReadLine();

            switch (word)
            {
                case "Ясно":
                    Console.WriteLine("Clearly");
                    break;
                case "Облачно":
                    Console.WriteLine("Cloudy");
                    break;
                case "Ветренно":
                    Console.WriteLine("Windy");
                    break;
                case "Тепло":
                    Console.WriteLine("Heat");
                    break;
                case "Холодно":
                    Console.WriteLine("Cold");
                    break;
                case "Жарко":
                    Console.WriteLine("Hot");
                    break;
                case "Дождь":
                    Console.WriteLine("Rainy");
                    break;
                case "Солнце":
                    Console.WriteLine("Sunny");
                    break;
                case "Прохладно":
                    Console.WriteLine("Cool");
                    break;
                case "Сухо":
                    Console.WriteLine("Dry");
                    break;
                default:
                    Console.WriteLine("unknown word");
                    break;

            }
        }

        public static void Task_4()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}