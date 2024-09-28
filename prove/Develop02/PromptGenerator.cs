using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {
        "What was your favorite activity today?",
        "What hobby did you do today?",
        "What did you read about in the scriptures?",
        "Name one act of kindness you performed today:",
        "What could you have done better today?",
        "Name one thing you could improve on for tomorrow: ",
        "Do you have a favorite food you ate today?",
        "How did you feel the Lord's hand in your life today?",
        "Were you thinking of someone today?",
        "What was your favorite talk from this last conference?"
    };

    public string GetRandomPrompt()
    {
        // Get random index value and lookup string in _prompts

        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, 9);
        string selectedPrompt = _prompts[indexNumber];
        
        return selectedPrompt;
    }
}