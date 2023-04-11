using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        StreamReader sr = new StreamReader("settings.txt");
        string[] beallitasok;

        MediaPlayer musicplayer = new MediaPlayer();
        bool zene;
        double hangero;
        public MenuWindow()
        {
            InitializeComponent();



            beallitasok = sr.ReadLine().Split(";");
            sr.Close();
            if (bool.Parse(beallitasok[0]))
            {
                lbZene.Content = "Be";
                btnBe.Opacity = 0.5;
            }
            else
            {
                lbZene.Content = "Ki";
                btnKi.Opacity = 0.5;
            }
            sliHangero.Value = double.Parse(beallitasok[1]);
            if (beallitasok[2] == "1280")
            {
                sliFelbontas.Value = 1;
                lbFelbontas.Content = beallitasok[2] + "x" + beallitasok[3];
            }
            else if (beallitasok[2] == "1600")
            {
                sliFelbontas.Value = 2;
                lbFelbontas.Content = beallitasok[2] + "x" + beallitasok[3];
            }
            else
            {
                sliFelbontas.Value = 3;
                lbFelbontas.Content = beallitasok[2] + "x" + beallitasok[3];
            }

            zene = bool.Parse(beallitasok[0]);
            hangero = double.Parse(beallitasok[1]);
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
        private void btnTalcaraTesz_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnBe_Click(object sender, RoutedEventArgs e)
        {
            lbZene.Content = "Be";
            btnBe.Opacity = 0.5;
            btnKi.Opacity = 1;
            beallitasok[0] = "true";
            PlaybackMusic();
        }

        private void btnKi_Click(object sender, RoutedEventArgs e)
        {
            lbZene.Content = "Ki";
            btnBe.Opacity = 1;
            btnKi.Opacity = 0.5;
            beallitasok[0] = "false";
            musicplayer.Stop();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            beallitasok[1] = sliHangero.Value.ToString();
            if (sliFelbontas.Value==1)
            {
                beallitasok[2] = "1280";
                beallitasok[3] = "720";
            }
            else if (sliFelbontas.Value == 2)
            {
                beallitasok[2] = "1600";
                beallitasok[3] = "900";
            }
            else
            {
                beallitasok[2] = "1920";
                beallitasok[3] = "1280";
            }

            using (StreamWriter writer = File.CreateText("settings.txt"))
            {
                writer.WriteLineAsync(beallitasok[0] + ";" + beallitasok[1] + ";" + beallitasok[2] + ";" + beallitasok[3]);
                writer.Close();
            }

            MainWindow openMain = new MainWindow();
            openMain.Show();
            musicplayer.Stop();
            this.Close();         
        }

        private void sliFelbontas_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliFelbontas.Value==1)
            {
                lbFelbontas.Content = "1280x720";
            }
            else if (sliFelbontas.Value == 2)
            {
                lbFelbontas.Content = "1600x900";
            }
            else
            {
                lbFelbontas.Content = "1920x1080";
            }
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

        public void PlaybackMusic()
        {
            if (musicplayer != null)
            {
                musicplayer.Open(new Uri("MenuWindowMusic.mp3", UriKind.RelativeOrAbsolute));
                musicplayer.MediaEnded += new EventHandler(Media_Ended);
                musicplayer.Volume = hangero;
                musicplayer.Play();

                return;
            }
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            musicplayer.Open(new Uri("MenuWindowMusic.mp3", UriKind.RelativeOrAbsolute));
            musicplayer.Volume = hangero;
            musicplayer.Play();
        }

        private void sliHangero_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            musicplayer.Volume=sliHangero.Value;
        }
    }
}
