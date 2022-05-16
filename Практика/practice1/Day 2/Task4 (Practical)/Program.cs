for (int i = 100; i <= 999; i++)
{
    string str = Convert.ToString(i);
    if (str[0] == str[1] || str[1] == str[2] || str[0] == str[2])
    {
        Console.WriteLine(str);
    }
}