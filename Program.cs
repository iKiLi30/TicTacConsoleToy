using System;
namespace TicTacConcolToy
{
    internal class Program
    {
        char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public char playerCharacter = ' ';

        public bool gameEnded = false;
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
                    gameEnded = true;
                    Console.WriteLine("Please press any keq to reset the game");
                    Console.ReadKey();
                    resetBoard();
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
                    gameEnded = true;
                    Console.WriteLine("Please press any keq to reset the game");
                    Console.ReadKey();
                    resetBoard();
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
                    gameEnded = true;
                    Console.WriteLine("Please press any keq to reset the game");
                    Console.ReadKey();
                    resetBoard();
                    break;
                }
            }
        }
        public void Draw()
        {
            if (boardPositions[0] != '1' && boardPositions[1] != '2' && boardPositions[2] != '3' &&
                boardPositions[3] != '4' && boardPositions[4] != '5' && boardPositions[5] != '6' &&
                boardPositions[6] != '7' && boardPositions[7] != '8')
            {
                Console.Clear();
                Console.WriteLine("It's a DRAW!!!!");
                gameEnded = true;
                Console.WriteLine("Please press any keq to reset the game");
                Console.ReadKey();
                resetBoard();

            }
        }
        void resetBoard()
        {
            char[] ArrBoardInitialize = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            boardPositions = ArrBoardInitialize;
            DrawBoard();
            gameEnded = false;

        }

     
        static void Main(string[] args)
        {
            Program program = new Program();
            bool validInputGiven = true;
            int currentTurn = 1;
            int playerInput = 0;

            while (!program.gameEnded)
            {
                program.DrawBoard();
                validInputGiven = false;
                while (!validInputGiven)
                {
                    Console.WriteLine("\nReady Player {0}: It's your move!", currentTurn);
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());  
                    }
                    catch
                    {
                        Console.WriteLine("Please inter a number...");
                        continue;
                    }
                    if ((playerInput == 1) && (program.boardPositions[0] == '1')) validInputGiven = true;
                    else if ((playerInput == 2) && (program.boardPositions[1] == '2')) validInputGiven = true;
                    else if ((playerInput == 3) && (program.boardPositions[2] == '3')) validInputGiven = true;
                    else if ((playerInput == 4) && (program.boardPositions[3] == '4')) validInputGiven = true;
                    else if ((playerInput == 5) && (program.boardPositions[4] == '5')) validInputGiven = true;
                    else if ((playerInput == 6) && (program.boardPositions[5] == '6')) validInputGiven = true;
                    else if ((playerInput == 7) && (program.boardPositions[6] == '7')) validInputGiven = true;
                    else if ((playerInput == 8) && (program.boardPositions[7] == '8')) validInputGiven = true;
                    else if ((playerInput == 9) && (program.boardPositions[8] == '9')) validInputGiven = true;
                    else
                    {
                        Console.WriteLine("Please choose a valid and avalidable board positin. \nGive it another try..");
                    }

                }
                if (currentTurn == 2)
                {
                    program.Play(currentTurn, playerInput);
                    currentTurn = 1;
                }
                else if (currentTurn == 1)
                { 
                    program.Play(currentTurn, playerInput);
                    currentTurn = 2;
                }
                program.HorizontalWin();
                program.VerticalWin();
                program.DiagonalWin();
                program.Draw();

            }
        }
    }
}
