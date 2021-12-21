using System;
using static System.Console;

namespace TicTacToe
{
    public class Display
    {
        public static void StartGame()
        { 
            WriteLine();
            WriteLine("P - PVP Game");
            WriteLine("C - Computer Opponent");
            WriteLine("G - Play a random computer vs computer game");
            WriteLine("Press anything else to quit");

            string gameType = ReadLine();

            Clear();
            TicTacToe.SharedFunctions.RandomizeStartPlayer();

            if(gameType.ToUpperInvariant() == "P")
            {
                PVPGame.DisplayPVPGrid();
            }
            if(gameType.ToUpperInvariant() == "G")
            {
                RandomGame.DisplayComputerVsComputerGrid();
            }
            if(gameType.ToUpperInvariant() == "C")
            {
                ComputerGame.RandomizePlayer();
                ComputerGame.DisplayComputerGrid();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}