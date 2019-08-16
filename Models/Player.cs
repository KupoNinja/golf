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

        public int ScoreCount(string player)
        {
            Console.Write("Strokes for " + player);
            int playerScore = Convert.ToInt32(Console.ReadLine());

            Scores.Add(playerScore);
            return playerScore;
        }

        public Player(string name)
        {
            Name = name;
            Scores = new List<int>();
        }
    }
}