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
        ConsoleKeyInfo key;

        while ( 3 > 2 )  // Always
        {
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");

            key = Console.ReadKey();
            if (((key.KeyChar == '4') || (key.KeyChar == 'a'))
                    && (x > 0))
                x = x-1;

            if (((key.KeyChar == '6')  || (key.KeyChar == 'd'))
                    && (x < 79))
                x = x+1;

            if (((key.KeyChar == '8')  || (key.KeyChar == 'w'))
                    && (y > 0))
                y = y-1;

            if (((key.KeyChar == '2')  || (key.KeyChar == 's'))
                    && (y < 24))
                y = y+1;
        }
    }
}
