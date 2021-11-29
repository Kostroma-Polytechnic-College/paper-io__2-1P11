using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Game
    {
        Player[,] field;
        Player[] players;
        int n = 5;
        public Game (int n)
        {
            this.field = new Player[10 * n, 10 * n] ;
            this.players = new Player[n];
        }
    }
}
