using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Player
    {
        Random rnd = new Random();
        private int[] color;

        public Player()
        {
            this.color = GenerateColorPlayer();
        }

        private int[] GenerateColorPlayer()
        {
            int[] color = new int[] { rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10) };
            Console.WriteLine(color);
            return color;
        }
    }
}
