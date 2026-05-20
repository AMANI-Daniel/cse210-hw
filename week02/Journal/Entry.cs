public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} -- promptText: {_promptText}\n{_entryText}\n");
    }
}   