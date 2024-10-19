using System;

class TicTacToe
{
    static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // 1 = Player1, 2 = Player2
    static int choice;     // User choice for position
    static int flag = 0;   // 1 means someone has won, -1 means a draw, 0 means keep playing

    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
            Board();

            choice = int.Parse(Console.ReadLine());

            if (board[choice] != 'X' && board[choice] != 'O')
            {
                if (player % 2 == 0)
                {
                    board[choice] = 'O';
                    player++;
                }
                else
                {
                    board[choice] = 'X';
                    player++;
                }
            }
            else
            {
                Console.WriteLine("Sorry; the row {0} is already marked with a {1}", choice, board[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait 2 seconds. The board is loading again...");
                System.Threading.Thread.Sleep(2000);
            }
            flag = CheckWin();
        }
        while (flag != 1 && flag != -1);

        Console.Clear();
        Board();

        if (flag == 1)
        {
            Console.WriteLine("Player {0} has won!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("It's a Draw!");
        }

        Console.ReadLine();
    }

    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
        Console.WriteLine("     |     |      ");
    }

    private static int CheckWin()
    {
        #region Winning Condition
        if (board[1] == board[2] && board[2] == board[3])
        {
            return 1;
        }
        else if (board[4] == board[5] && board[5] == board[6])
        {
            return 1;
        }
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        else if (board[3] == board[6] && board[6] == board[9])
        {
            return 1;
        }
        else if (board[1] == board[5] && board[5] == board[9])
        {
            return 1;
        }
        else if (board[3] == board[5] && board[5] == board[7])
        {
            return 1;
        }
        #endregion

        // Checking for Draw
        for (int i = 1; i <= 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return 0;
            }
        }

        return -1;
    }
}
