﻿using System.Text;


var firstFilePath = @"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job4\firstD.txt";
var secondFilePath = @"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job4\secondD.txt";

if (!File.Exists(firstFilePath))
{
    File.Create(firstFilePath);
}
if (!File.Exists(secondFilePath))
{
    File.Create(secondFilePath);
}

var linesFromFile1 = File.ReadAllLines(firstFilePath);
var linesFromFile2 = File.ReadAllLines(secondFilePath);




if (linesFromFile1.Count() != linesFromFile2.Count())
{
    Console.WriteLine("Файлы разные по длине");
}
else
{
    Console.WriteLine("Файл одинаковые по длине");
    var index = FindFirstIndex(linesFromFile1, linesFromFile2);

    if (index == -1)
    {
        Console.WriteLine("Файлы одинаковые");
    }
    else
    {
        Console.WriteLine($"Файлы разные в строке {index}");
    }
}


int FindFirstIndex(string[] linesFromFile1, string[] linesFromFile2)
{
    var index = -1;
    for (int i = 0; i < linesFromFile1.Count(); i++)
    {
        if (!linesFromFile1[i].Equals(linesFromFile2[i]))
        {
            return i + 1;
        }
    }
    return index;
}