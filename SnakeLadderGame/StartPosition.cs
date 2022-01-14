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
        Random random = new Random();       // object of random class
        //Method
        public void RunGame()
        {
            Console.WriteLine("Player position is: " + position);
            int randomNum = random.Next(1,7);         //random number berween 1 to 6
            Console.WriteLine("randomNum: "+randomNum);
        }
    }
}
