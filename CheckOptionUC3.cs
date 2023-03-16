using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class CheckOptionUC3
    {
       
        
            public const int CaseOfNoPlay = 0;
            public const int CaseOfNoLadder = 1;
            public const int CaseOfSnake = 2;

            public static void CasePosition()
            {
                Console.WriteLine("Stert the Snake and Ladder Game");
                Console.WriteLine("Single player at start Position 0");
                Random random = new Random();
                int RollDice = random.Next(1, 6);
                Console.WriteLine("Player rolls the dice and get: " + RollDice);
                Random random1 = new Random();
                int option = random1.Next(3);
                int position = 0;


                switch (option)
                {
                    case CaseOfNoPlay:
                        {
                            Console.WriteLine("No Play " + position);
                            Console.WriteLine("Player stay at same position-");
                            break;
                        }
                    case CaseOfNoLadder:
                        {
                            Console.WriteLine("LADDER " + (RollDice + position));
                            Console.WriteLine("Player move ahead {0} steps ", RollDice);
                            break;
                        }
                    case CaseOfSnake:
                        {
                            Console.WriteLine("Snake " + (RollDice - position));
                            Console.WriteLine("Player move back {0} steps ", RollDice);
                            break;
                        }
                }
            }

        
    }
}
