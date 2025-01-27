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

//Print initial board

do
{ 
    //Ask player 1 for choice and update

    //print new board

    //Ask player 2 for choice and update

    //print new board

    //Check if there's a winner

} while (!gameOver);