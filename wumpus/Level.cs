using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus
{
    public class Level
    {
        
        public RoomFilling[,] _room  = new RoomFilling [8, 8];
        
        public void RoomFillingStart(Level level)
        {
           
             _room[0,0] = RoomFilling.Entrance;
          
            
            Console.WriteLine(level._room[0,0]);
        }

        public void DrawLevel(Level level, int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write($" |{level._room[i, j]}| ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }



    }


  

}

