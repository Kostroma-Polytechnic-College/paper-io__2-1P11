using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            try
            {
                int countPlayers = int.Parse(countPlayersField.Text);

                StartGameWindow game = new StartGameWindow(countPlayers);
                this.Close();
                game.Show();
                // game.ViewModel = countPlayersField.Text;
                // game.ShowViewModel();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка введенных данных. Пожалуйста введите корректные данные!"); ;
            }
        }

        
    }
}
