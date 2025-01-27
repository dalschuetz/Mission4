using System.Security.Cryptography.X509Certificates;
using Mission4;

TicTacTools ttt = new TicTacTools();

/*Welcome User to the Game
 * Create board array
 * Ask player for choice and update array
 * Print board
 * Call choose winner method and notify when a win has occured
 * */

string[,] Board = new string[3,3];
Board[0, 0] = "A1";
Board[0, 1] = "A2";
Board[0, 2] = "A3";
Board[1, 0] = "B1";
Board[1, 1] = "B2";
Board[1, 2] = "B3";
Board[2, 0] = "C1";
Board[2, 1] = "C2";
Board[2, 2] = "C3";
bool gameOver = false;
string Player1 = "";
string Player2 = "";
string Player1Guess = "";
string Player2Guess = "";
string SpacesGuessed = ""; 

Console.WriteLine("Welcome to Tic-Tac-Toe");
Console.WriteLine("Player 1: Please enter your name: ");
Player1 = Console.ReadLine();
Console.WriteLine("Player 2: Please enter your name: ");
Player2 = Console.ReadLine();
Console.Write("Generating Board");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");
Console.WriteLine(" Board Generated");


//print initial board
ttt.PrintBoard(Board);

do
{
    //Ask player 1 for choice and update
    Console.WriteLine($"{Player1}: Please Enter a Space Name");
    Player1Guess = Console.ReadLine().ToUpper();
    //check if guess is valid
    Player1Guess = tTools.Validate(Player1Guess, SpacesGuessed);
    SpacesGuessed += Player1Guess;
    //if it is valid then fill in 
    tTools.FillBoard(Player1Guess, "X", Board);
    //print new board
    ttt.PrintBoard(Board);
    //Check if there's a winner
    gameOver = ttt.ChooseWinner(Board, Player1, Player2);

    if (!gameOver)
    {
        //Ask player 2 for choice and update
        Console.WriteLine($"{Player2}: Please Enter a Space Name");
        Player2Guess = Console.ReadLine().ToUpper();
        //check if guess is valid
        Player2Guess = tTools.Validate(Player2Guess, SpacesGuessed);
        SpacesGuessed += Player2Guess;
        tTools.FillBoard(Player2Guess, "O", Board);
        //print new board
        ttt.PrintBoard(Board);
        //Check if there's a winner
        gameOver = ttt.ChooseWinner(Board, Player1, Player2);
    }
    
} while (!gameOver);



internal class tTools
{
    public static string Validate(string guess, string SpacesGuessed)
    {
        while (true) // Keep looping until a valid guess is entered
        {
            if (guess.Length != 2)
            {
                Console.WriteLine("The guess needs to be a letter and a number (e.g., A1). Try again.");
            }
            else if (!(guess == "A1" || guess == "A2" || guess == "A3" ||
                       guess == "B1" || guess == "B2" || guess == "B3" ||
                       guess == "C1" || guess == "C2" || guess == "C3"))
            {
                Console.WriteLine("The guess needs to be a valid space (A1-C3). Try again.");
            }
            else if (SpacesGuessed.Contains(guess))
            {
                Console.WriteLine("You have already guessed that space. Try again.");
            }
            else
            {
                return guess; // Valid guess, return it
            }

            // Prompt user for a new guess if the previous one was invalid
            Console.Write("Enter a new guess: ");
            guess = Console.ReadLine().ToUpper();
        }
    }


    //add guess to the board
    public static void FillBoard(string guess, string symbol, string[,] Board)
    {
        if (guess == "A1")
        {
            Board[0, 0] = symbol;
        }
        else if (guess == "A2")
        {
            Board[0, 1] = symbol;
        }
        else if (guess == "A3")
        {
            Board[0, 2] = symbol;
        }
        else if (guess == "B1")
        {
            Board[1, 0] = symbol;
        }
        else if (guess == "B2")
        {
            Board[1, 1] = symbol;
        }
        else if (guess == "B3")
        {
            Board[1, 2] = symbol;
        }
        else if (guess == "C1")
        {
            Board[2, 0] = symbol;
        }
        else if (guess == "C2")
        {
            Board[2, 1] = symbol;
        }
        else if (guess == "C3")
        {
            Board[2, 2] = symbol;
        }
    }

};