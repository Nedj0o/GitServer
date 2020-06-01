using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndDirections
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
        }

        public ComputerPlayer(int id, string username, int xPos, int yPos, int score) : base(id, username, xPos, yPos, score)
        {
        }

        public void findNextMove()
        {
            Random rnd = new Random();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int a = rnd.Next(numbers.Length);

            if (a % 2 == 0)
            {
                int pos = getxPos() + 1;
                setxPos(pos);
            }
            else
            {
                int pos = getxPos() - 1;
            }
            int b = rnd.Next(numbers.Length);

            if (b % 2 != 0)
            {
                int pos = getyPos() + 1;
                setyPos(pos);
            }
            else
            {
                int pos = getyPos() - 1;
            }

        }
    }
}
