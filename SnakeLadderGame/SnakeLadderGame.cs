using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class StartPosition
    {
        //Instance Variables.
        int position = 0;
        const int MAX_POSITION = 100;
        const int LADDER = 1;
        const int SNAKE = 2;
        Random random = new Random();       // object of random class
        //Method
        public void RunGame()
        {
            Console.WriteLine("Player position is: " + position);
            //Using While Loop to iterate Game till position reaches max position.
            int diceCount = 0;
            while (position < MAX_POSITION)
            {
                int diceValue = random.Next(1, 7);          //random number berween 1 to 6 for Dice Value.
                int playCheck = random.Next(0, 3);          //Generating random value between 0 to 2 to control movement of player position
                switch (playCheck)
                {
                    case LADDER:
                        if (position <= MAX_POSITION && (position + diceValue) <= MAX_POSITION)
                        {
                            position += diceValue;
                        }
                        break;
                    case SNAKE:
                        if (position > 0 && (position - diceValue) >= 0)
                        {
                            position -= diceValue;
                        }
                        break;
                    default:
                        break;
                }
                diceCount++;
                Console.WriteLine("Dice Roll:{0} and Player Position:{1}", diceCount, position);
            }
            Console.WriteLine("\nNumber of Dice played: "+diceCount+"\tPlayer Position: "+ position);
        }
    }
}
