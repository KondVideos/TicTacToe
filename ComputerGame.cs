using System;
using static TicTacToe.SharedFunctions;

namespace TicTacToe
{
    class ComputerGame
    {
        public static bool playerTurn;
        public static void TakePlayerTurn()
        {
            CheckIfPlayIsCorrectForHuman();
            ChangeComputerPlayer();
            DisplayComputerGrid();   
        }
        public static void TakeComputerTurn()
        {
            CheckIfPlayIsCorrectForComputer();
            ChangeComputerPlayer();
            DisplayComputerGrid();  
        }
        public static void ChangeComputerPlayer()
        {
            if(playerTurn)
            {
                playerTurn = false;
            }
            else
            {
                playerTurn = true;
            }
        }
        public static void DisplayComputerGrid()
        {
            DisplayGrid();
            CheckEndGame();
            if(playerTurn)
            {
                TakePlayerTurn();
            }
            else
            {
                TakeComputerTurn();
            }
        }
        public static void RandomizePlayer()
        {
            Random random = new Random();
            if(random.Next(0, 2) == 0)
            {
                playerTurn = true;
            }
            else
            {
                playerTurn = false;
            }
        }
    }
}