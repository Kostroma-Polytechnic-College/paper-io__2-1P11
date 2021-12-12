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
        Player[,] field;
        List<Player> players = new List<Player>();
        public Game(int players)
        {
            this.field = new Player[10 * players, 10 * players] ;
        }
        public void StartGame() // Этот метод должен вызываться из конструктора при создании игры.
        {
            List<Point> locations = new List<Point>();
            for (int row = 0; row < field.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < field.GetLength(0) - 2; column++)
                {
                    if (CheckPoint(row, column))
                    {
                        locations.Add(new Point(row, column));
                    }
                }
            }
            if (locations.Count() != 0)
            {
                Random rnd = new Random();
                Point location = locations[rnd.Next(locations.Count())]; // Если полей для появления игрока несколько, то выбрается случайным образом одно.
                CreatePlayer(location);
            }
        }
        private bool CheckPoint(int row, int column)
        {
            for (int r = row; r < row + 3; r++)
            {
                for (int c = column; c < column + 3; c++)
                {
                    if (field[r, c] != null) return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для создания игрока на поле размером 3х3
        /// </summary>
        public void CreatePlayer(Point location)
        {
            Player player = new Player(new Point(location.X + 1, location.Y + 1));
            players.Add(player);
            for (int i = (int)location.X; i < location.X + 3; i++)
            {
                for (int j = (int)location.Y; j < (int)location.Y + 3; j++)
                {
                    field[i, j] = player;
                }
            }
    }
}
