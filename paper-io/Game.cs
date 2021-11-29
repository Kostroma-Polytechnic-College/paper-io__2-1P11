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
        Player[] players;
        public Game (int n)
        {
            this.field = new Player[10 * n, 10 * n] ;
            this.players = new Player[n];
        }
        public void StartGame() // Этот метод должен вызываться из конструктора при создании игры.
        {
            List<Point> locations = new List<Point>();
            for (int row = 0; row < field.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < field.GetLength(0) - 2; column++)
                {
                    /// <summary>
                    /// Здесь должна быть проверка свободна ли терротория для появления игрока.
                    /// </summary>
                }
            }
            if (locations.Count() != 0)
            {
                Random rnd = new Random();
                Point location = locations[rnd.Next(locations.Count())]; // Если полей для появления игрока несколько, то выбрается случайным образом одно.
                CreatePlayer(location);
            }
        }
        /// <summary>
        /// Метод для создания игрока на поле размером 3х3
        /// </summary>
        public void CreatePlayer(Point location)
        {
            /// <summary>
            /// Как то нужно добавлять в наш массив
            /// </summary>
        }
    }
}
