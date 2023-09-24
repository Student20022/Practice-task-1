using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть логiн: ");
        string login = Console.ReadLine();

        if (IsLoginValid(login))
        {
            Console.WriteLine("Логiн коректний.");
        }
        else
        {
            Console.WriteLine("Логiн некоректний.");
        }
    }

    static bool IsLoginValid(string login)
    {      
        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

        return Regex.IsMatch(login, pattern);
    }
}
