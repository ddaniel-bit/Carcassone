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
        Uri hoversound = new Uri("hoversound.mp3", UriKind.RelativeOrAbsolute);
        MediaPlayer hoverplayer = new MediaPlayer();

        MediaPlayer musicplayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            PlaybackMusic();
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
            hoverplayer.Open(hoversound);
            hoverplayer.Play();

            btnStart.Foreground = MouseEnterColor();
        }

        private void btnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            btnStart.Foreground = MouseLeaveColor();
        }

        private void btnSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverplayer.Open(hoversound);
            hoverplayer.Play();

            btnSettings.Foreground = MouseEnterColor();
        }

        private void btnSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSettings.Foreground = MouseLeaveColor();
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            hoverplayer.Open(hoversound);
            hoverplayer.Play();

            btnExit.Foreground = MouseEnterColor();
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            btnExit.Foreground = MouseLeaveColor();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
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
            
        }

        public void PlaybackMusic()
        {
            if (musicplayer != null)
            {
                musicplayer.Open(new Uri("MainWindowMusic.mp3", UriKind.RelativeOrAbsolute));
                musicplayer.MediaEnded += new EventHandler(Media_Ended);
                musicplayer.Volume = 0.1;
                musicplayer.Play();

                return;
            }
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            musicplayer.Open(new Uri("MainWindowMusic.mp3", UriKind.RelativeOrAbsolute));
            musicplayer.Volume = 0.1;
            musicplayer.Play();
        }
    }
}
