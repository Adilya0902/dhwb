using System;

namespace дз8_2 
{
    class Program
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, которую хотите перевернуть:");
            string text = Console.ReadLine(); 
            string reversedText = ReverseString(text); 
            Console.WriteLine($"Результат: {reversedText}"); 
            Console.ReadKey(); 
        }
    }
}