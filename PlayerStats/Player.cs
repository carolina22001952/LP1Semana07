using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames, wonGames;

        public int HighScore 
        {
            get => highScore;
            set
            {
                if(newScore > highScore)
                    highScore = newScore;
            }
        }

        public string Name { get; }
        public float WinRate 
        { 

        }

        public void PlayGame(bool win)
        {
            playedGames++;
            while(win == true)
            {
                wonGames++;
            }

        }

        private Player(string name)
        {
            Name = name;
            this.highScore = 0;
            this.playedGames = 0;
            this.wonGames = 0;
        }
    }
}