//Define the system libraries needed for compiling.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Makes a namespace for our program and gives it a name.
namespace TasoCalc

{
    //The class for the main program script.
    public class Program

    {
        //Define all the variables we will need.
        private static double Level;
        private static double MessagesNeed;
        private static double XPgain;
        private static double XPneeded;
        private static double CurrentXP;
        private static double XPLeft;
        private static double MessagesLeft;

        //The actual script goes here.
        public static void Main()

        {



            Console.ForegroundColor = ConsoleColor.White;
            //Set your Taso level to the Level variable using console input.
            Console.Write("Please enter your Taso level: ");
            Level = Convert.ToDouble(Console.ReadLine());

            if (Level > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Due to the XP gain randomizer on Taso activated once a user surpasses level 30, this program will not have correct calculations. In 5 seconds, this window will close.");
                System.Threading.Thread.Sleep(
                (int)System.TimeSpan.FromSeconds(5).TotalMilliseconds);
                System.Environment.Exit(1);
            }
            else
            {
                //Since the level is under 30, nothing needs to be done
            }

            //Set your current XP count
            Console.Write("Please enter how much XP you have: ");
            CurrentXP = Convert.ToDouble(Console.ReadLine());

 
            //Calculates the information needed.
            double MessagesNeed = Level * 8;
            double XPgain = 45 + (Level * 5);
            double XPneeded = MessagesNeed * XPgain;
            double XPLeft = XPneeded - CurrentXP;
            double MessagesLeft = MessagesNeed - (CurrentXP / XPgain);

            //Writes the results to the console.
            //Results are color coded.
            //Green- Levels and XP
            //Red- Leveling up
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your Taso level is " + Level);
            Console.WriteLine("You currently have " + CurrentXP + "XP");
            Console.WriteLine("You would get " + XPgain + "XP per message.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You would need a total of " + XPneeded + "XP to level up.");
            Console.WriteLine("You would need around " + MessagesNeed + " Messages to level up.");
            Console.WriteLine("You need " + XPLeft + "XP points to get to the next level.");
            Console.WriteLine("You need " + MessagesLeft + " more messages to level up.");

            //Halt execution for 5 seconds so the user has a chance to read the results.
            System.Threading.Thread.Sleep(
            (int)System.TimeSpan.FromSeconds(5).TotalMilliseconds);

        }

    }

}