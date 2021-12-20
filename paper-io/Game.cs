using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace paper_io
{
    public class Game
    {
        private Player[,] field;
        private List<Player> players;
        private static List<Color> colorsList = new List<Color>
        {
            (Color)ColorConverter.ConvertFromString("#FFFF0000"),
            (Color)ColorConverter.ConvertFromString("#FF0000FF"),
            (Color)ColorConverter.ConvertFromString("#FF008000"),
            (Color)ColorConverter.ConvertFromString("#FFFFFF00"),
            (Color)ColorConverter.ConvertFromString("#FFFFA500"),
            (Color)ColorConverter.ConvertFromString("#FFADD8E6"),
            (Color)ColorConverter.ConvertFromString("#FFA52A2A"),
            (Color)ColorConverter.ConvertFromString("#FF000000"),
            (Color)ColorConverter.ConvertFromString("#FFEE82EE"),
            (Color)ColorConverter.ConvertFromString("#FFFFC0CB"),
        };

        public Game(int countPlayers)
        {
            field = new Player[countPlayers * 10, countPlayers * 10];
            for (int i = 0; i < countPlayers; i++)
            {
                this.players.Add(new Player(new Point(), colorsList[i]));
            }
        }
        public void PlacePlayer(Player player, Point point)
        {
            int x = (int)point.X;

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
