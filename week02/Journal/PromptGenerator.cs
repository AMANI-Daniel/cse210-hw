public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
    
}