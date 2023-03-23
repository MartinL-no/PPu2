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
                UserTurn(board, isPlayerOne);
                isPlayerOne = !isPlayerOne;
            }
            
        }
        public static void UserTurn(Board board, bool isPlayerOne)
        {
            board.ShowBoard();

            Console.Write("Player one enter the index position you want to choose: ");

            var userInput = Console.ReadLine();

            board.AddUserChoice(true, userInput);
        }
    }
}