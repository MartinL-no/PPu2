using System;

namespace TrePaRadMartinLars
{
    internal class Board
    {
        int[] CurrentBoard;

        public Board()
        {
            CurrentBoard = new int[9];
        }
        static void ShowBoard()
        {
            /*
                0 1 2
                3 4 5
                6 7 8
            */
            Console.WriteLine("Use the nummber index for position");
            Console.WriteLine("012");
            Console.WriteLine("345");
            Console.WriteLine("678");

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                {
                    Console.Write("_");
                }

                if (board[i] == 1)
                {
                    Console.Write("X");
                }

                if (board[i] == 2)
                {
                    Console.Write("O");
                }

                if (i == 2 || i == 5 i || i == 8) { Console.WriteLine(); }
            }
        }
    }
}
