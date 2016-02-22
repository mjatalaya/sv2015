// Search in a list of words (version 1)

// Create a C# program to ask the user for a sentence and display the 
// words which do not appear in the dictionary called "UK-dict.txt". It 
// must repeat until the user enters and empty sentence.

// 17-02-2016

using System;
using System.IO;
using System.Collections;

public class Dictionary
{
    public static void Main()
    {
        ArrayList dict = new ArrayList();
        StreamReader inFile = File.OpenText("UK-dict.txt");
        string text;        
        do
        {
            text = inFile.ReadLine();
            if (text != null)
            {
                text = text.ToLower();
                dict.Add(text);
            }
        }
        while (text != null);
        inFile.Close();
        
        do
        {
            Console.Write("Enter a sentence (Enter to finish): ");
            text = Console.ReadLine().ToLower();
            
            if (text != "")
            {
                string[] words = text.Trim().Split(' ');
                
                for (int j = 0; j < words.Length; j++)
                    if (! dict.Contains(words[j]))
                        Console.WriteLine(words[j]+" ");
            }
        }
        while (text != "");
        Console.WriteLine("Bye!");
    }
}
