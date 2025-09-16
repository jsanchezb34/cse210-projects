using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public string[] prompts = {
        "What made you smile today?",
        "Describe a challenge you overcame.",
        "What are you grateful for?",
        "Write about a peaceful moment."
    };

    public string GetRandomPrompts()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}
