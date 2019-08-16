using System.Collections.Generic;

namespace Golf.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        List<int> Scores { get; set; }

        int ScoreCount(string playerName); //NOTE responsible for summing up all of the scores in the player's Scores property and displaying the result to the user
    }
}