using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class TicTacTools
    {
        //prints board
        public void PrintBoard(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(board[i, 0] + " | " + board[i, 1] + " | " + board[i, 2]);
                if (i < 2)
                {
                    Console.WriteLine("-------------");
                }
            }
        }
        // method to find a winner if there is one.
        public bool ChooseWinner(string[,] board, string player1, string player2)
        {
            
            //checking rows for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != null)
                {
                    if (board[i,0] == "X")
                    {
                        Console.WriteLine(player1 + " is the winner");
                    }
                    else
                    {
                        Console.WriteLine(player2 + " is the winner");
                    } 
                }
            }
            //checking columns for winner
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    if (board[0, i] == "X")
                    {
                        Console.WriteLine(player1 + " is the winner");
                    }
                    else
                    {
                        Console.WriteLine(player2 + " is the winner");
                    }
                    return true; 
                }
            }
            // check first diaganal for winner
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == "X")
                {
                    Console.WriteLine(player1 + " is the winner");
                }
                else
                {
                    Console.WriteLine(player2 + " is the winner");
                }
                return true; 
            }
            // check second diaganal for winner
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != null)
            {
                if (board[0,2] == "X")
                {
                    Console.WriteLine(player1 + " is the winner");
                }
                else
                {
                    Console.WriteLine(player2 + " is the winner");
                }
                return true; 
            }
            return false;

        }
    }
}
