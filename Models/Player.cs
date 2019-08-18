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

        public void DisplayFinalScore()
        {
            Scores.Sum();
        }

        public Player(string name)
        {
            Name = name;
            Scores = new List<int>();
        }
    }
}