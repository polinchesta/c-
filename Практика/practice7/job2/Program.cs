using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PhoneNumberGrabber
{
    private string text { get; set; }
    private Regex regex;
    List<string> list = new List<string>();

    public PhoneNumberGrabber(string str)
    {
        text = str;
        regex = new Regex(@"(?<!(\d|\d[ -]))[1-9][ -]?\d[ -]?\d[ -]?\d[ -]?\d[ -]?\d[ -]?\d(?!(\d|[ -]\d))");
    }

    public string[] GetPhoneNumbers()
    {
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            string str = match.ToString();
            list.Add(str);
        }

        return list.ToArray();
    }
}


internal class program
{
    private static void Main()
    {
        Console.WriteLine("Введите строку с номером");
        string str = Console.ReadLine();
        PhoneNumberGrabber grabber = new PhoneNumberGrabber(str);
        string[] arr = grabber.GetPhoneNumbers();

        foreach (var s in arr)
        {
            Console.WriteLine("Номер телефона: " + s);
        }
    }
}