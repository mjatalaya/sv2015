// Replace text in a text file
// Version 2: with error checking

using System;
using System.IO;

public class TextReplace
{
    
    public static int Main(string[] args ) 
    {
        StreamReader myFile;
        StreamWriter myNewFile;
        string line;
        
        if (args.Length != 3)
        {
            Console.WriteLine("Missing parameters: file word replaceStr");
            return 1;
        }
        
        if ( ! File.Exists(args[0]) )
        {
            Console.WriteLine("File not found");
            return 2;
        }
        
        try
        {
            myFile = File.OpenText (args[0]);
            myNewFile = File.CreateText(args[0]+".out");
            
            do
            {
                line = myFile.ReadLine();
                
                if (line != null)
                {
                    line = line.Replace(args[1], args[2]);
                    myNewFile.WriteLine(line);
                }
            }
            while (line!= null);
            
            myFile.Close();
            myNewFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path was too long");
            return 3;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return 4;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return 5;
        }
        
        return 0;
    }
}
