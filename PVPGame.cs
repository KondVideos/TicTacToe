using static TicTacToe.SharedFunctions;

namespace TicTacToe
{
    public class PVPGame
    {
        public static void DisplayPVPGrid()
        {
            DisplayGrid();
            CheckEndGame();
            TakeTurn();
        }
        public static void TakeTurn()
        {
            CheckIfPlayIsCorrectForHuman();
            DisplayPVPGrid();
        }
    }
}