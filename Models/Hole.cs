using Golf.Interfaces;

namespace Golf.Models
{
    public class Hole : IHole
    {
        public int Par { get; set; }

        public Hole(int par)
        {
            Par = par;
        }
    }
}