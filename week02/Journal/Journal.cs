

using System.Reflection.Metadata.Ecma335;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {

        Console.WriteLine("Saving to a file...");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText}| {entry._entryText}");

            }
        }

    }

    public void LoadFromFile(string file)
    {

        Console.WriteLine("Loading from file....");
        string[] lines = System.IO.File.ReadAllLines(file);

       

        foreach (string line in lines)
        {
            Entry outEntry = new Entry();
            string[] parts = line.Split("|");
            outEntry._date = parts[0];
            outEntry._promptText = parts[1];
            outEntry._entryText = parts[2];
            _entries.Add(outEntry);

        }
    }



}