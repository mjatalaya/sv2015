/* Sergio Martínez Mira
 * Appending to a text file (c)
 * */
 
using System;
using System.IO;

public class AppendSentences
{

    public static void Main()
    {
        string newline;
        
        using (StreamWriter myFile = new StreamWriter("sentences.txt", true))
        {
            do
            {
                Console.Write("Enter a sentence: ");
                newline = Console.ReadLine();
                if (newline != "")
                    myFile.WriteLine(newline);
            }
            while(newline != "");
        }
    }
}
