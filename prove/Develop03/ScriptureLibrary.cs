using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();


    // Add scripture to library
    public void AddScripture(Reference reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    // Random select and return scripture
    public Scripture SelectRandomScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("The scripture library is empty.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}