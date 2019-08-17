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

        public int ScoreCount(int numberOfStrokes)
        {
            Scores.Add(numberOfStrokes);

            // for (var i = 0; i < Players.Count; i++)
            // {
            //     Console.Write("Strokes for " + Players.Count.);
            //     int playerScore = Convert.ToInt32(Console.ReadLine());

            //     Scores.Add(playerScore);
            // }

            // NOTE Add each individual player score and total here?

            return numberOfStrokes;
        }

        public Player(string name)
        {
            Name = name;
            Scores = new List<int>();
        }
    }
}