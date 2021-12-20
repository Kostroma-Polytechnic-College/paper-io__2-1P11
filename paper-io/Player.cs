using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace paper_io
{
    public class Player
    {
        private Color color;
        public Point Location;
        public Player(Point location, Color playerColor)
        {
            this.color = playerColor;
            this.Location = location;
        }
    }
}
