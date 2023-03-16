using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class GameWith2PlayerUC7
    {


        public const int CaseOfNoPlay = 0;
        public const int CaseOfLadder = 1;
        public const int CaseOfSnake = 2;
        public const int MaxPosition = 100;

        public static void SLWithTwoPlayer()
        {
            Console.WriteLine("Start the snake and ladder game");
            Console.WriteLine("Single player at starting position 0");
            Console.WriteLine(" ");
            int positionOfPlayer1 = 0;
            int positionOfPlayer2 = 0;
            int step1 = 0;
            int step2 = 0;
            bool currentTurn = true;

            while (positionOfPlayer1 != MaxPosition && positionOfPlayer1 != MaxPosition)
            {
                if (currentTurn == true)
                {
                    Random random = new Random();
                    int RollDice = random.Next(1, 6);
                    Console.WriteLine("Player rolls the die and get: " + RollDice);
                    Random random1 = new Random();
                    int option = random1.Next(3);

                    switch (option)
                    {
                        case CaseOfNoPlay:
                            {
                                Console.WriteLine("Optinc NO PLAY selected " + positionOfPlayer1);
                                Console.WriteLine("Player stey at same postion");
                                break;
                            }

                        case CaseOfLadder:
                            {
                                Console.WriteLine("Option LADDER selected " + positionOfPlayer1);
                                Console.WriteLine("Player move ahead " + RollDice);
                                positionOfPlayer1 = RollDice + positionOfPlayer1;
                                break;
                            }

                        case CaseOfSnake:
                            {
                                Console.WriteLine("Option SNAKE is selected " + (RollDice + positionOfPlayer1));
                                Console.WriteLine("Player move behind by " + RollDice);
                                positionOfPlayer1 = positionOfPlayer1 - RollDice;
                                currentTurn = false;
                                break;
                            }
                    }
                    if (positionOfPlayer1 < 0)
                    {
                        positionOfPlayer1 = 0;
                        Console.WriteLine("Player have to restart from position " + positionOfPlayer1);
                    }
                    if (positionOfPlayer1 > MaxPosition)
                    {
                        positionOfPlayer1 = positionOfPlayer1 - RollDice;
                        Console.WriteLine(" Your chance is skip. Stay at same position " + positionOfPlayer1);
                    }
                    step1++;
                    Console.WriteLine("Player rolls the dice till now " + step1);
                    Console.WriteLine("Current position of the player is: " + positionOfPlayer1);
                    Console.WriteLine(" ");
                }
                else
                {
                    Random random = new Random();
                    int RollDice = random.Next(1, 6);
                    Console.WriteLine("Player rolls the die and get: " + RollDice);
                    Random random1 = new Random();
                    int option = random1.Next(3);

                    switch (option)
                    {
                        case CaseOfNoPlay:
                            {
                                Console.WriteLine("Optinc NO PLAY selected " + positionOfPlayer1);
                                Console.WriteLine("Player stey at same postion");
                                break;
                            }

                        case CaseOfLadder:
                            {
                                Console.WriteLine("Option LADDER selected " + positionOfPlayer1);
                                Console.WriteLine("Player move ahead " + RollDice);
                                positionOfPlayer1 = RollDice + positionOfPlayer1;
                                break;
                            }

                        case CaseOfSnake:
                            {
                                Console.WriteLine("Option SNAKE is selected " + (RollDice + positionOfPlayer1));
                                Console.WriteLine("Player move behind by " + RollDice);
                                positionOfPlayer1 = positionOfPlayer1 - RollDice;
                                currentTurn = false;
                                break;
                            }
                    }
                    if (positionOfPlayer2 < 0)
                    {
                        positionOfPlayer2 = 0;
                        Console.WriteLine("Player have to restart from position " + positionOfPlayer2);
                    }
                    if (positionOfPlayer2 > MaxPosition)
                    {
                        positionOfPlayer2 = positionOfPlayer2 - RollDice;
                        Console.WriteLine(" Your chance is skip. Stay at same position " + positionOfPlayer2);
                    }
                    step2++;
                    Console.WriteLine("Player rolls the dice till now " + step2);
                    Console.WriteLine("Current position of the player is: " + positionOfPlayer2);
                    Console.WriteLine(" ");
                }

            }
            if (positionOfPlayer1 == 100)
            {
                Console.WriteLine("Total number of time player1 roll the dice is: " + step1);
                Console.WriteLine("!!!*!!! Player 1 won the game !!!*!!!");
            }
            else
            {
                Console.WriteLine("Total number of time player2 roll the dice is: " + step2);
                Console.WriteLine("!!!*!!! Player 2 won the game !!!*!!!");
            }
        }
    }
}

