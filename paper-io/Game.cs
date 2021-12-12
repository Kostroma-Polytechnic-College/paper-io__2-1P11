using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Game
    {
        private int countPlayers;
        private List<Player> players;

        public Game(int countPlayers)
        {
            this.countPlayers = countPlayers;
            GeneretePlayers(countPlayers);

        }

        private void GeneretePlayers(int countPlayers)
        {
            for (int i = 0; i < countPlayers; i++)
            {
                this.players.Add(new Player());
            }
        }

        
    }
}
