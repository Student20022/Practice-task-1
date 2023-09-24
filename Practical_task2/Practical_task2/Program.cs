using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст: ");
        string inputText = Console.ReadLine();

        string filteredText = FilterText(inputText);

        Console.WriteLine("Результат:");
        Console.WriteLine(filteredText);
    }

    static string FilterText(string inputText)
    {
        string pattern = @"\b(коректний|логін)\b";
        string replacement = "валідний ім'я користувача";

        string filteredText = Regex.Replace(inputText, pattern, replacement, RegexOptions.IgnoreCase);

        return filteredText;
    }
}
