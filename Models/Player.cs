using System;
using System.Collections.Generic;
using System.Linq;
using Golf.Interfaces;

namespace Golf.ModelsActual
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }
        public int TotalScore { get; set; }

        public int DisplayFinalScore()
        {
            TotalScore = Scores.Sum();
            return TotalScore;
        }

        public Player(string name)
        {
            Name = name;
            Scores = new List<int>();
        }
    }
}