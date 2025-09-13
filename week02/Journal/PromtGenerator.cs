using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private static readonly List<string> prompts = new List<string>
    
    {
        "What made you smile today?",
        "Describe a conversation you had with someone.",
        "Did you learn something new today?",
        "What was the most relaxing moment of your day?",
        "Did you help someone today? How?",
        "What was the tastiest thing you ate today?",
        "Did you face any challenges today?",
        "What did you do for fun today?",
        "How did you feel when you woke up?",
        "What is one thing you are grateful for today?"
    };

    public Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

}
