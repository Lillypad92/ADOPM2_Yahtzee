using System;
using System.Collections.Generic;
using Helpers;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region sprint 3
            Console.WriteLine("\n\nSprint 3");

            try
            {
                int _nrDice;
                //csConsoleInput.TryReadInt32("How many dice?", 1, 10, out _nrDice);

                Console.WriteLine("How many dice?");
                string input = Console.ReadLine();
                _nrDice = int.Parse(input);

                ICupOfDice cup2 = new csCupOfDice(_nrDice);
                Console.WriteLine($"Newly created cup\n{cup2}");
                Console.WriteLine($"NrOfDice: {cup2.Count}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nSorted cup\n{cup2.Sort()}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nShaken cup\n{cup2.Shake()}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nHighest: {cup2.Highest}");
                Console.WriteLine($"Lowest: {cup2.Lowest}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error running the program, pls try again");
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

            
            #region sprint 4
            Console.WriteLine("\n\nSprint 4");

            ICupDoubleDice doubleDice = new csCupDoubleDice();
            Console.WriteLine($"Cup of double dices\n{doubleDice}");
            Console.WriteLine($"NrOfDice: {doubleDice.Count}");
            Console.WriteLine($"IsPair: {doubleDice.IsPair}");

            Console.WriteLine($"\nSorted cup\n{doubleDice.Sort()}");
            Console.WriteLine($"\nShaken cup\n{doubleDice.Shake()}");
            Console.WriteLine($"IsPair: {doubleDice.IsPair}");

            Console.WriteLine($"\nHighest: {doubleDice.Highest}");
            Console.WriteLine($"Lowest: {doubleDice.Lowest}");

            //Continue with your code
            #endregion

            /*
            #region sprint 5
            Console.WriteLine("\n\nSprint 5");

            //Test the YahtzeeDices
            ICupYahtzeeDice yahtzeeDice = null;
            Console.WriteLine($"Cup of Yahtzee dices\n{yahtzeeDice}");

            #endregion
            */


            //Continue with your code
            Console.WriteLine("\n\nThank you for playing");

            Console.ReadKey();
        }
    }
}
