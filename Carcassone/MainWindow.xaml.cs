using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
        MediaPlayer musicplayer = new MediaPlayer();


        StreamReader sr = new StreamReader("settings.txt");
        bool zene;
        double hangero;
            
        public MainWindow()
        {
            InitializeComponent();

            while (!sr.EndOfStream)
            {
                string[] beallitasok = sr.ReadLine().Split(";");
                zene =bool.Parse(beallitasok[0]);
                hangero = double.Parse(beallitasok[1]);
                
            }
            sr.Close();
            if (zene)
            {
                PlaybackMusic();
            }
            
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
            PalyaBetoltoWindow openGame = new PalyaBetoltoWindow();
            openGame.ShowDialog();
            musicplayer.Stop();
            this.Close();
        }

        private void btnStart_MouseEnter(object sender, MouseEventArgs e)
        {
            btnStart.Foreground = MouseEnterColor();
        }

        private void btnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            btnStart.Foreground = MouseLeaveColor();
        }

        private void btnSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSettings.Foreground = MouseEnterColor();
        }

        private void btnSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSettings.Foreground = MouseLeaveColor();
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            btnExit.Foreground = MouseEnterColor();
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            btnExit.Foreground = MouseLeaveColor();
        }

        private void btnLeaderboard_MouseEnter(object sender, MouseEventArgs e)
        {
            btnLeaderboard.Foreground = MouseEnterColor();
        }

        private void btnLeaderboard_MouseLeave(object sender, MouseEventArgs e)
        {
            btnLeaderboard.Foreground = MouseLeaveColor();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, RoutedEventArgs e)
        {
            musicplayer.Stop();
            LeaderboardWindow openLeaderboard = new LeaderboardWindow();
            openLeaderboard.Show();
            this.Close();
        }


        private static LinearGradientBrush MouseEnterColor()
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));
            return myVerticalGradient;
        }

        private static LinearGradientBrush MouseLeaveColor()
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));
            return myVerticalGradient;
        }

        private void btnTalcaraTesz_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            musicplayer.Stop();
            MenuWindow openMenu = new MenuWindow();
            openMenu.Show();
            this.Close();
        }

        public void PlaybackMusic()
        {
            if (musicplayer != null)
            {
                musicplayer.Open(new Uri("MainWindowMusic.mp3", UriKind.RelativeOrAbsolute));
                musicplayer.MediaEnded += new EventHandler(Media_Ended);
                musicplayer.Volume = hangero;
                musicplayer.Play();

                return;
            }
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            musicplayer.Open(new Uri("MainWindowMusic.mp3", UriKind.RelativeOrAbsolute));
            musicplayer.Volume = hangero;
            musicplayer.Play();
        } 
    }
}
