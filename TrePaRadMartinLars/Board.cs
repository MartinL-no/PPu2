using System;

namespace TrePaRadMartinLars
{
    internal class Board
    {
        readonly int[] CurrentBoard;

        public Board()
        {
            CurrentBoard = new int[9];
        }
        public void ShowBoard()
        {
  
            Console.WriteLine("Use the nummber index for position");
            Console.WriteLine("012");
            Console.WriteLine("345");
            Console.WriteLine("678");

            for (int i = 0; i < 9; i++)
            {
                if (CurrentBoard[i] == 0)
                {
                    Console.Write("_");
                }

                if (CurrentBoard[i] == 1)
                {
                    Console.Write("X");
                }

                if (CurrentBoard[i] == 2)
                {
                    Console.Write("O");
                }

                if (i == 2 || i == 5 || i == 8) { Console.WriteLine(); }
            }
        }
        public void AddUserChoice(bool isPlayerOne, string userInput)
        {
            int number;

            if (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Incorrect input");
            }
            else if (isPlayerOne)
            {
                CurrentBoard[number] = 1;
            }
            else
            {
                CurrentBoard[number] = 2;
            }
            ShowBoard();
        }
    }
}
