using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndDirections
{
    public class Player
    {
        private int id;
        private string username;
        private int xPos;
        private int yPos;
        private int score;

        public Player()
        {

        }

        public Player(int id, string username, int xPos, int yPos, int score)
        {
            this.id = id;
            this.username = username;
            this.xPos = xPos;
            this.yPos = yPos;
            this.score = score;
        }

        public int getId()
        {
            return id;
        }

        public int setId(int a)
        {
            return this.id = a;
        }

        public string getUsername()
        {
            return username;
        }

        public string setUsername(string a)
        {
            return this.username = a;
        }

        public int getxPos()
        {
            return xPos;
        }

        public int setxPos(int a)
        {
            return this.xPos = a;
        }

        public int getyPos()
        {
            return yPos;
        }

        public int setyPos(int a)
        {
            return this.yPos = a;
        }

        public int getScore()
        {
            return score;
        }

        public int setScore(int a)
        {
            return this.score = a;
        }
    }
}
