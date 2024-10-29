using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor.Entities
{
    internal class Player
    {
        public string Name { get; }
        public int Move { get; set; }
        public int Points { get; set; }

        public Player(string name)
        {
            Name = name;
            Points = 0;
        }
    }
}

