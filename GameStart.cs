﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class GameStart
    {
        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;
        public static void GameIsStart()
        {
            int Player = 1;
            int Player_Position = 0;

            Console.WriteLine("Player Position is : " + Player_Position);

            Random random = new Random();
            int DieRoll = random.Next(1, 7);

            Console.WriteLine("Rolling the Die : " + DieRoll);

            int check = random.Next(1, 4);
            switch(check)
            {
                case NO_PLAY:
                    Player_Position = Player_Position + 0;
                    break;
                case LADDER:
                    Player_Position = Player_Position + DieRoll;
                    break;
                case SNAKE:
                    Player_Position = Player_Position - DieRoll;
                    break;
            }
            Console.WriteLine("After Rollint Die Palyer Position is : " + Player_Position);
        }
    }
}
