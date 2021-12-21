using static TicTacToe.SharedFunctions;

namespace TicTacToe
{
    class RandomGame
    {   
        public static void DisplayComputerVsComputerGrid()
        {
            DisplayGrid();
            CheckEndGame();
            TakeComputerVsComputerTurn();
        }
        public static void TakeComputerVsComputerTurn()
        {
            CheckIfPlayIsCorrectForComputer();
            DisplayComputerVsComputerGrid();  
        }
    }
}