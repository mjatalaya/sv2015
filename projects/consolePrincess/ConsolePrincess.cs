/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

using System;
using System.Threading;

public class ConsolePrincess
{
    public static void Main()
    {
        int x = 40;
        int y = 12;
        int birdX = 20;
        int birdY = 5;
        int birdSpeed = 1;
        ConsoleKeyInfo key;
        int finished = 0;
        int frame = 1;

        while ( finished == 0 )
        {
            // Draw elements on screen
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x,y);
            if (frame == 1)
                Console.WriteLine("A");  // Player
            else
                Console.WriteLine("À");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(birdX,birdY);
            Console.WriteLine("W");  // Bird

            // Check keys and move player
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                        && (x > 0))
                {
                    //frame = frame == 1 ? 0 : 1;
                    frame = (frame + 1) % 2;
                    x = x-1;
                }

                if (((key.KeyChar == '6')  || (key.Key == ConsoleKey.RightArrow))
                        && (x < 79))
                {
                    frame = (frame + 1) % 2;
                    x = x+1;
                }

                if (((key.KeyChar == '8')  || (key.Key == ConsoleKey.UpArrow))
                        && (y > 0))
                {
                    frame = (frame + 1) % 2;
                    y = y-1;
                }

                if (((key.KeyChar == '2')  || (key.Key == ConsoleKey.DownArrow))
                        && (y < 24))
                {
                    frame = (frame + 1) % 2;
                    y = y+1;
                }
                    
                if (key.Key == ConsoleKey.Escape)
                    finished = 1;
            }
                
            // Move other elements
            if (birdX == 79)
                birdSpeed = -1;
            if (birdX == 0)
                birdSpeed = 1;
                
            //if ((birdX == 79) || (birdX == 0))
            //    birdSpeed = -birdSpeed;
                
            birdX = birdX + birdSpeed;
            
            // Check collisions and game state
            if ((birdX == x) && (birdY == y))
                finished = 1;
            
            // Pause till next frame (10fps)
            Thread.Sleep(100);
        }
        Console.Clear();
        Console.SetCursorPosition(35,12);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Game Over!");
        
        Console.SetCursorPosition(1,18);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
}
