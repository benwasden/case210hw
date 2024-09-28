using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {
        "What was your favorite activity today?",
        "What hobby did you do today?",
        "What did you read about in the scriptures?",
        "Name one act of kindness you performed today:",
        "What could you have done better today?",
    };

    public string GetRandomPrompt()
    {
        // Get random index value and lookup string in _prompts

        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, 4);
        string selectedPrompt = _prompts[indexNumber];
        
        return selectedPrompt;
    }
}