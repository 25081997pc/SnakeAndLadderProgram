﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class GameStart
    {
        public static void GameIsStart()
        {
            int Player = 1;
            int Player_Position = 0;

            Console.WriteLine("Player Position is : " + Player_Position);

            Random random = new Random();
            int DieRoll = random.Next(1, 7);

            Console.WriteLine("Rolling the Die : " + DieRoll);
        }
    }
}
