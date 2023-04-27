//program to check for consecutive strings in text
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the test");
        string text = Console.ReadLine();
        Console.WriteLine("test for same consecutive letters in text is " + test(text));
    }
    public static bool test(string text)
    {
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == text[i + 1])
                return true;
        }
        return false;
    }
}
