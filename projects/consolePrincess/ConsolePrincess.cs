/* 
   Console Princess 
   A console game by students at I.E.S. San Vicente, Spain
*/

using System;

public class ConsolePrincess
{
    public static void Main()
    {
        int x = 40;
        int y = 12;
        int key;
        
        while ( 3 > 2 )  // Always
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");
            
            key = Convert.ToInt32( Console.ReadLine() );
            if (key == 4)
                x = x-1;
        }
    }
}
