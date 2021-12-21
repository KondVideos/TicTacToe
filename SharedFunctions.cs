using System;
using System.Threading;
using static TicTacToe.Display;
using static System.Console;

namespace TicTacToe
{
    public class SharedFunctions
    {
        public static char[] values = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        public static string separator = "-------------";
        public static string gridLine = "| {0} | {1} | {2} |";
        public static char currentPlayer;
        public static bool spotTaken = true;
        public static int currentNumber;
        public static bool GameIsDrawn()
        {
            foreach(char a in values)
            {
                if(a != 'X' && a != 'O')
                {
                    return false;
                }
            }
            return true;
        }
        public static void ResetGrid()
        {
            values[0] = '1';
            values[1] = '2';
            values[2] = '3';
            values[3] = '4';
            values[4] = '5';
            values[5] = '6';
            values[6] = '7';
            values[7] = '8';
            values[8] = '9';
            StartGame();
        }
        public static void ChangePlayer()
        {
            if (currentPlayer == 'X')
            {
                currentPlayer = 'O';
            }
            else
            {
                currentPlayer = 'X';
            }
        }
        public static bool AreEqual(char a, char b, char c)
        {
            return a == b && b == c;
        }
        public static void CheckEndGame()
        {
            if(AreEqual(values[0], values[1], values[2]) ||
               AreEqual(values[3], values[4], values[5]) ||
               AreEqual(values[6], values[7], values[8]) ||
               AreEqual(values[0], values[3], values[6]) ||
               AreEqual(values[1], values[4], values[7]) ||
               AreEqual(values[2], values[5], values[8]) ||
               AreEqual(values[0], values[4], values[8]) ||
               AreEqual(values[2], values[4], values[6]))
            {
                ChangePlayer();
                WriteLine($"{currentPlayer} Won!");
                ResetGrid();
            }
            if(GameIsDrawn())
            {
                WriteLine("It's a draw!");
                ResetGrid();
            }
        }
        public static void RandomizeStartPlayer()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if(number == 0)
            {
                currentPlayer = 'X';
            }
            else
            {
                currentPlayer = 'O';
            }
        }
        public static void DisplayGrid()
        {
            WriteLine(separator);
            WriteLine(gridLine, values[0], values[1], values[2]);
            WriteLine(separator);
            WriteLine(gridLine, values[3], values[4], values[5]);
            WriteLine(separator);
            WriteLine(gridLine, values[6], values[7], values[8]);
            WriteLine(separator);
        }
        public static void CheckIfPlayIsCorrectForHuman()
        {
            WriteLine($"Turn of player \"{currentPlayer}\"");
            while(spotTaken == true)
            {
                try
                {
                    string input = ReadLine();
                    currentNumber = int.Parse(input)-1;

                    if(values[currentNumber] == 'X' || values[currentNumber] == 'O')
                    {
                        spotTaken = true;
                    } 
                    else
                    {
                        spotTaken = false;
                    }
                }
                catch
                {
                    spotTaken = true;
                }    

            }
            spotTaken = true;
            values[currentNumber] = currentPlayer;  
            Clear();
            ChangePlayer();
        }
        public static void CheckIfPlayIsCorrectForComputer()
        {
            WriteLine($"Turn of computer \"{currentPlayer}\"");
            Thread.Sleep(300);
            while(spotTaken == true)
            {
                try
                {
                    Random random = new Random();
                    string input = Convert.ToString(random.Next(0,10));
                    currentNumber = int.Parse(input)-1;

                    if(values[currentNumber] == 'X' || values[currentNumber] == 'O')
                    {
                        spotTaken = true;
                    } 
                    else
                    {
                        spotTaken = false;
                    }
                }
                catch
                {
                    spotTaken = true;
                }    
            }
            spotTaken = true;
            values[currentNumber] = currentPlayer;  
            Clear();
            ChangePlayer(); 
        }
    }
}