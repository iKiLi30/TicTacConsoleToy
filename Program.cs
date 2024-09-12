using System;
namespace TicTacConcolToy
{
    internal class Program
    {
        char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void DrawBoard()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", boardPositions[0], boardPositions[1], boardPositions[2]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("-------------------");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", boardPositions[3], boardPositions[4], boardPositions[5]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("-------------------");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", boardPositions[6], boardPositions[7], boardPositions[8]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("-------------------");
        }
        public char playerCharacter = ' ';
        public void Play(int player, int input)
        {
            if (player == 1) playerCharacter = 'X';
            else if (player == 2) playerCharacter = 'O';

            switch (input)
            {
                case 1: boardPositions[0] = playerCharacter; break;
                case 2: boardPositions[1] = playerCharacter; break;
                case 3: boardPositions[2] = playerCharacter; break;
                case 4: boardPositions[3] = playerCharacter; break;
                case 5: boardPositions[4] = playerCharacter; break;
                case 6: boardPositions[5] = playerCharacter; break;
                case 7: boardPositions[6] = playerCharacter; break;
                case 8: boardPositions[7] = playerCharacter; break;
                case 9: boardPositions[8] = playerCharacter; break;
            }
        }
        char[] playerCharacters = { 'X', 'O' };


        public void HorizontalWin()
        {
            foreach (char playerCharacter in playerCharacters)
            {
                if (((boardPositions[0] == playerCharacter) && (boardPositions[1] == playerCharacter) && (boardPositions[2] == playerCharacter)) ||
                    ((boardPositions[3] == playerCharacter) && (boardPositions[4] == playerCharacter) && (boardPositions[5] == playerCharacter)) ||
                    ((boardPositions[6] == playerCharacter) && (boardPositions[7] == playerCharacter) && (boardPositions[8] == playerCharacter)))
                {
                    Console.Clear();
                    if (playerCharacter == 'X') { Console.WriteLine("Congratulations Player 1"); }
                    else { Console.WriteLine("Congratulations Player 2"); }
                    break;
                }
            }
        }
        public void VerticalWin()
        {
            foreach (char playerCharacter in playerCharacters)
            {
                if (((boardPositions[0] == playerCharacter) && (boardPositions[3] == playerCharacter) && (boardPositions[6] == playerCharacter)) ||
                    ((boardPositions[1] == playerCharacter) && (boardPositions[4] == playerCharacter) && (boardPositions[7] == playerCharacter)) ||
                    ((boardPositions[3] == playerCharacter) && (boardPositions[5] == playerCharacter) && (boardPositions[8] == playerCharacter)))
                {
                    Console.Clear();
                    if (playerCharacter == 'X') { Console.WriteLine("Congratulations Player 1"); }
                    else { Console.WriteLine("Congratulations Player 2"); }
                    break;
                }
            }
        }
        public void DiagonalWin()
        {
            foreach (char playerCharacter in playerCharacters)
            {
                if (((boardPositions[0] == playerCharacter) && (boardPositions[4] == playerCharacter) && (boardPositions[8] == playerCharacter)) ||
                    ((boardPositions[6] == playerCharacter) && (boardPositions[4] == playerCharacter) && (boardPositions[2] == playerCharacter)))
                {
                    Console.Clear();
                    if (playerCharacter == 'X') { Console.WriteLine("Congratulations Player 1"); }
                    else { Console.WriteLine("Congratulations Player 2"); }
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Play(1, 5);
            program.DrawBoard();
        }
    }
}
