
public class Scripture
{
    //Declaring variables as private
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    Random rand = new Random();

    //Declaring the constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] inputTexts = text.Split(" ");

        foreach (string inputText in inputTexts)
        {
            _words.Add(new Word(inputText));
        }
    }
    //Declaring the methods to be used

    public void HideRandomWords(int numberToHide)
    {
        List<Word> unHiddenWords = new List<Word>();

        foreach (Word word in _words)
        {

            //look
            if (!word.IsHidden())
            {
                unHiddenWords.Add(word);
            }
        }
        
        for (int i = 0; i < numberToHide && unHiddenWords.Count > 0; i++)
        {
            int index = rand.Next(unHiddenWords.Count);
            unHiddenWords[index].Hide();
            unHiddenWords.RemoveAt(index);

        }
    }
    public string GetDisplayText()
    {

        string refer = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            refer += " " + word.GetDisplayText();
        }
        return refer;

    }
    public bool IsCompletelyHidden()
    {

        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}