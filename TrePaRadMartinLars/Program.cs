namespace TrePaRadMartinLars
{
    internal class Program
    {
        private int[] board = new int[9];

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            board = new Board();
            board.ShowBoard();


            //Run();
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
        static void Run()
        {
            board = new Board();
            board.ShowBoard();
        }
    }
}