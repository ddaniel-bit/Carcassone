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

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            GameWindow openGame = new GameWindow();
            openGame.Show();
            this.Close();
        }

        private void btnStart_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(202, 121, 93));
            btnStart.Foreground = szines;

        }

        private void btnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(248, 208, 53));
            btnStart.Foreground = szines;
        }

        private void btnSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(202, 121, 93));
            btnSettings.Foreground = szines;
        }

        private void btnSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(248, 208, 53));
            btnSettings.Foreground = szines;
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(202, 121, 93));
            btnExit.Foreground = szines;
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush szines = new SolidColorBrush(Color.FromRgb(248, 208, 53));
            btnExit.Foreground = szines;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
