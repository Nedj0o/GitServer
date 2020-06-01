using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndDirections
{
    public class HumanPlayer : Player
    {
        public enum directions
        {
            N,
            S,
            E,
            W
        }
        private directions facing;

        public HumanPlayer(int id, string username, int xPos, int yPos, int score, directions facing) : base(id, username, xPos, yPos, score)
        {
            this.facing = facing;
        }

        public HumanPlayer() : base()
        {

        }


        public directions getFacing()
        {
            return facing;
        }

        private directions setFacing(directions a)
        {
            return this.facing = a;
        }

        public void turnLeft()
        {
            if (facing.Equals(directions.N))
            {
                setFacing(directions.W);
            }
            else if (facing.Equals(directions.W))
            {
                setFacing(directions.S);
            }
            else if (facing.Equals(directions.S))
            {
                setFacing(directions.E);
            }
            else if (facing.Equals(directions.E))
            {
                setFacing(directions.N);
            }
        }

        public void turnRight()
        {
            if (facing.Equals(directions.N))
            {
                setFacing(directions.E);
            }
            else if (facing.Equals(directions.E))
            {
                setFacing(directions.S);
            }
            else if (facing.Equals(directions.S))
            {
                setFacing(directions.W);
            }
            else if (facing.Equals(directions.W))
            {
                setFacing(directions.N);
            }
        }
    }
}
