using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            Task_6();

            Console.ReadLine();
        }

        /// <summary>
        /// Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>
        public static void Task_1()
        {
            string test = "243523test90878762test114235test";
            Console.WriteLine(test);

            string testing = test.Replace("test", "testing");
            Console.WriteLine(testing);
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task_2()
        {
            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lessons";

            string sentence = string.Concat("\"", word1, "\" ", "\"", word2, "\" ", "\"", word3, "\" ", "\"", word4, "\" ", "\"", word5, "\"");
            Console.WriteLine(sentence);
        }
        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        ///Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        ///Результат вывести в консоль.
        /// </summary>
        public static void Task_3()
        {
            string s = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string substring = "abc";

            string firstPart = s.Substring(0, s.IndexOf(substring));
            string secondPart = s.Substring(firstPart.Length + substring.Length);
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);
        }

        /// <summary>
        /// Дана строка: Good day 
        ///Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        ///Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void Task_4()
        {
            string s = "Good day";
            string text = "The best!!!!!!!!!";

            string day = s.Substring(4);
            string newText = text.Insert(8, day);
            string result = string.Concat(newText.Substring(0, newText.Length - 1), "?");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Введите с консоли строку, которая будет содержать буквы и цифры. Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task_5()
        {
            string? s = Console.ReadLine();
            string letters = string.Empty;
            string numbers = string.Empty;

            foreach (char c in s)
            {
                if (Char.IsDigit(c))
                {
                    letters = string.Concat(letters, (char)c);
                }
                else
                    numbers = string.Concat(numbers, (char)c);
            }
            Console.WriteLine("letters: " + letters);
            Console.WriteLine("numbers: " + numbers);
        }

        /// <summary>
        /// Задайте 2 предложения из консоли. Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task_6()
        {
            Console.Write("Enter the first sentence: ");
            string? sentence1 = Regex.Replace(Console.ReadLine(), "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", " ").ToLower();
            Console.Write("Enter the second sentence: ");
            string? sentence2 = Regex.Replace(Console.ReadLine(), "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", " ").ToLower();

            string[] words1 = sentence1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            string[] words2 = sentence2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            foreach (string word1 in words1)
            {
                foreach (string word2 in words2)
                {
                    if (word1.Equals(word2))
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{word1} = {counter}");
                counter = 0;
            }
        }
    }
}