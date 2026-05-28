public class Word
{
    //Declaring member variables as private
    private string _text;
    private bool _isHidden;

    //Declaring constructor

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    //Declaring method
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}