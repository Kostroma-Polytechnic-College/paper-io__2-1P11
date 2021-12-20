using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{
    public class Game
    {
        public Player[,] field;
        List<Player> players = new List<Player>();
        public Game(int players)
        {
            field = new Player[10 * players, 10 * players];
        }
        public void PlacePlayer(Player player, Point point)
        {
            int x =(int)point.X;
            int y = (int)point.Y;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    field[i, j] = player;
                }
            }
            player.Location = new Point(x + 1, y + 1);
        }
    }
}
