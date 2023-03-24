using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrePaRadMartinLars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe\n");

            Run();
            // setup a board
            // Create board class

            // ShowBoard()
            // AddUserChoice()
            // setup two players
            // console output for start of game
            // take user input from console
            // function taking turns
            // function for deciding/checking winner
            // output who has won on console            
        }
        public static void Run()
        {
            var board = new Board();
            bool isPlayerOne = true;

            while (true)
            {
                board.ShowBoard();
                UserTurn(board, isPlayerOne);
                board.ShowBoard();

                if (board.HasPlayerWon(isPlayerOne))
                {
                    var currentPlayer = isPlayerOne ? 1 : 2;
                    Console.WriteLine($"Player {currentPlayer} has won!");

                    break;
                }
                isPlayerOne = !isPlayerOne;
                Console.Clear();
            }
            
        }
        public static void UserTurn(Board board, bool isPlayerOne)
        {
            while (true)
            {
                int boardIndex = GetUserInput(isPlayerOne);

                if (board.SlotIsEmpty(boardIndex))
                {
                    board.AddUserChoice(isPlayerOne, boardIndex);
                    break;
                }
                else
                {
                    Console.WriteLine("Board index is already taken");
                }
            }
        }
        public static int GetUserInput(bool isPlayerOne)
        {
            var currentPlayer = isPlayerOne ? 1 : 2;

            while (true)
            {
                Console.Write($"Player {currentPlayer} enter the index position you want to choose: ");
                var userInput = Console.ReadLine();

                try
                {
                    int boardIndex = Convert.ToInt32(userInput);
                    return boardIndex;
                }
                catch
                {
                    Console.WriteLine("You did not enter a number");
                }
            }
        }
    }
}