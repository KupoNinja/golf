using System;
using System.Collections.Generic;
using System.Linq;
using Golf.Interfaces;

namespace Golf.Models
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public void DisplayFinalScore()
        {
            int totalScore = Scores.Sum();
            Console.WriteLine("Your total score is: " + totalScore);
        }

        public Player(string name, List<int> scores)
        {
            Name = name;
            Scores = scores;
        }
    }
}