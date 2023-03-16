using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class PlayerPositionUC4
    {
        public const int CaseOfNoPlay = 0;
        public const int CaseOfLadder = 1;
        public const int CaseOfSnake = 2;
        public const int MaxPosition = 100;

        public static void ReachedHundred()
        {
            Console.WriteLine("Start the snake and ladder game");
            Console.WriteLine("Single player at starit position 0");
            Console.WriteLine(" ");
            int position = 0;
            while (position != MaxPosition)
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
                            Console.WriteLine("Optinc NO PLAY selected " + position);
                            Console.WriteLine("Player stey at same postion");
                            break;
                        }

                    case CaseOfLadder:
                        {
                            Console.WriteLine("Option LADDER selected " + position);
                            Console.WriteLine("Player move ahead " + RollDice);
                            position = RollDice + position;
                            break;
                        }

                    case CaseOfSnake:
                        {
                            Console.WriteLine("Option SNAKE is selected " + (RollDice + position));
                            Console.WriteLine("Player move behind by " + RollDice);
                            position = position - RollDice;
                            break;
                        }
                }
                if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("Player have to restart from position " + position);
                }
                Console.WriteLine("Current position of player is " + position);
                Console.WriteLine(" ");
            }
        }
    }
}
