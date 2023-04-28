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

        public float HighScore 
        {
            get => highScore;
            set
            {
                if(value > highScore)
                    highScore = value;
            }
        }

        public string Name { get; }
        public float WinRate => playedGames == 0 ? 0f : (float)wonGames / 
            playedGames;

        public void PlayGame(bool win)
        {
            playedGames++;
            if(win)
            {
                wonGames++;
            }

        }

        public Player(string name)
        {
            Name = name;
            this.highScore = 0;
            this.playedGames = 0;
            this.wonGames = 0;
        }
    }
}