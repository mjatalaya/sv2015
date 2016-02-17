﻿/// <summary>
///  Home accounting: Class IntroScreen (welcome screen)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Almost empty skeleton
   0.13  12-Feb-2016  Pablo and adrian: IntroScreen
 ---------------------------------------------------- */

using System;

namespace HomeAccounting2
{
    class IntroScreen
    {
        public void Show()
        {
            //Title
            Console.WriteLine("##      ##  ########  ##         ######    #######   ##     ##  ########");
            Console.WriteLine("##  ##  ##  ##        ##        ##    ##  ##     ##  ###   ###  ##      ");
            Console.WriteLine("##  ##  ##  ##        ##        ##        ##     ##  #### ####  ##      ");
            Console.WriteLine("##  ##  ##  ######    ##        ##        ##     ##  ## ### ##  ######  ");
            Console.WriteLine("##  ##  ##  ##        ##        ##        ##     ##  ##     ##  ##      ");
            Console.WriteLine("##  ##  ##  ##        ##        ##    ##  ##     ##  ##     ##  ##      ");
            Console.WriteLine(" ###  ###   ########  ########   ######    #######   ##     ##  ########");
            //Message
            Console.WriteLine();
            for (int i = 0; i < 22; i++)
                Console.Write(" ");
            Console.WriteLine("Welcome to Home Accounting");
            for (int i = 0; i < 10; i++)
                Console.Write(" ");
            Console.WriteLine("This program will help you manage your expenses and incomes"); 
        }
    }
}