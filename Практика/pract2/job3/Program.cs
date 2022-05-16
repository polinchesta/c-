try
{
    File im = new File("n_file", "12345", "15.05.2022");
    Console.WriteLine(im.name);
    Console.WriteLine(im.LenghtText);
    im.text = im.AppendFile("13245", im.text);
    Console.WriteLine(im.text);
    Console.WriteLine(im.LenghtText);
    Console.WriteLine(im.Status);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class File
{
    public string name;
    public string text;
    public string date;
    public string status;
    public string Status { get { return status; } }
    public int LenghtText { get { return (text.Length); } }
    public File(string name = "File1", string text = "", string date = "00.00.0000", string status = "")
    {
        try
        {
            if (string.IsNullOrEmpty(name)) throw new Exception("Name can not be empty");
            this.name = name;
            this.text = text;
            if (text.Length != 0) { status = "Файл заполнен"; } else { status = "Файл пустой"; }
            this.date = date;
            this.status = status;
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    public string AppendFile(string userText, string text)
    {
        text = text + userText;
        if (text.Length == 0) { status = "Файл пустой"; } else { status = "Файл заполнен"; }
        return text;
    }
}