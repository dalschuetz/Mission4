using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class TicTacTools
    {
        public void PrintBoard(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(board[i, 0] + " + " + board[i, 1] + " + " + board[i, 2]);
            }
        }
        // method to find a winner if there is one.
        public bool ChooseWinner(string[,] board)
        {
            
            //checking rows for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != null)
                {
                    Console.WriteLine(board[i, 0] + "is the winner");
                    return true; 
                }
            }
            //checking columns for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != null)
                {
                    Console.WriteLine(board[0, 1] + "is the winner");
                    return true; 
                }
            }
            // check first diaganal for winner
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != null)
            {
                Console.WriteLine(board[0, 0] + "is the winner");
                return true; 
            }
            // check second diaganal for winner
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != null)
            {
                Console.WriteLine(board[0, 2] + "is the winner");
                return true; 
            }
            return false;

        }
    }
}
