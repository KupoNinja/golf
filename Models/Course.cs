using System.Collections.Generic;
using Golf.Interfaces;

namespace Golf.Models
{
    public class Course : ICourse
    {
        public string Name { get; set; }
        public List<Hole> Holes { get; set; }

        public Course(string name)
        {
            Name = name;
            Holes = new List<Hole>();
        }
    }

}