using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{
    public class Player
    {
        public Point point;
        public int AxisX
        {
            get { return (int)point.X; }
        }
        public int AxisY
        {
            get { return (int)point.Y; }
        }
        public Player(Point location)
        {
            point = location;
        }
    }
}
