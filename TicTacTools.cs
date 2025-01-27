using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Receive board array
Prints Board based on information passed
Receive Board array input and returns if there's a winner
 */

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
        public string ChooseWinner(string[,] board)
        {
            string winner = "";
            //checking rows for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != null)
                {
                    winner = board[i, 0] + "is the winner";
                    return winner; 
                }
            }
            //checking columns for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != null)
                {
                    winner = board[0, i] + "is the winner";
                    return winner; 
                }
            }
            // check first diaganal for winner
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != null)
            {
                winner = board[0, 0] + "is the winner";
                return winner;
            }
            // check second diaganal for winner
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != null)
            {
                winner = board[0, 2] + "is the winner";
                return winner;
            }
            return "no winner yet";

        }
    }
}
