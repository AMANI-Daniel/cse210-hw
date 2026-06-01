
public class Comment
{
    public string _personName;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"{_personName}: {_text}");
    }

}