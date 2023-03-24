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
        public void ShowBoard()
        {
            Console.WriteLine("Use the nummber index for position");
            Console.WriteLine();
            Console.WriteLine("012");
            Console.WriteLine("345");
            Console.WriteLine("678");
            Console.WriteLine();

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
            Console.WriteLine();
        }
        public void AddUserChoice(bool isPlayerOne, int boardIndex)
        {
            
            if (isPlayerOne)
            {
                CurrentBoard[boardIndex] = 1;
            }
            else
            {
                CurrentBoard[boardIndex] = 2;
            }
        }

        public bool HasPlayerWon(bool isPlayerOne)
        {
            var player = isPlayerOne ? 1 : 2;

            if (CurrentBoard[0] == player && CurrentBoard[1] == player && CurrentBoard[2] == player)
            {
                return true;
            }
            else if (CurrentBoard[3] == player && CurrentBoard[4] == player && CurrentBoard[5] == player)
            {
                return true;
            }
            else if (CurrentBoard[6] == player && CurrentBoard[7] == player && CurrentBoard[8] == player)
            {
                return true;
            }
            else if (CurrentBoard[0] == player && CurrentBoard[3] == player && CurrentBoard[6] == player)
            {
                return true;
            }
            else if (CurrentBoard[1] == player && CurrentBoard[4] == player && CurrentBoard[7] == player)
            {
                return true;
            }
            else if (CurrentBoard[2] == player && CurrentBoard[5] == player && CurrentBoard[8] == player)
            {
                return true;
            }
            else if (CurrentBoard[0] == player && CurrentBoard[4] == player && CurrentBoard[8] == player)
            {
                return true;
            }
            else if (CurrentBoard[6] == player && CurrentBoard[4] == player && CurrentBoard[2] == player)
            {
                return true;
            }
            return false;
        }

        internal bool SlotIsEmpty(int boardIndex)
        {
            if (CurrentBoard[boardIndex] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
