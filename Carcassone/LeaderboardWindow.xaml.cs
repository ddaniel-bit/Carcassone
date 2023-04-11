using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Shapes;

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for LeaderboardWindow.xaml
    /// </summary>
    public partial class LeaderboardWindow : Window
    {
        ObservableCollection<Leaderboard> leaderboard = new ObservableCollection<Leaderboard>();
        public LeaderboardWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("leaderboard.txt");
            while (!sr.EndOfStream)
            {
                string[] mezok = sr.ReadLine().Split(";");
                Leaderboard Ujadat = new Leaderboard(mezok[0], int.Parse(mezok[1]));
                leaderboard.Add(Ujadat);


            }
            dgLeaderboard.ItemsSource = leaderboard;
            sr.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnTalcaraTesz_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));
            btnExit.Foreground = myVerticalGradient;
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));
            btnExit.Foreground = myVerticalGradient;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
          //  musicplayer.Stop();
            MainWindow openMain = new MainWindow();
            openMain.Show();
            this.Close();
        }
    }
}
