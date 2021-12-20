using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace paper_io
{
    class Game
    {
        private Player[,] gamematrix;
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
            for (int i = 0; i < countPlayers; i++)
            {
                this.players.Add(new Player(colorsList[i]));
            }
        }
    }
}
