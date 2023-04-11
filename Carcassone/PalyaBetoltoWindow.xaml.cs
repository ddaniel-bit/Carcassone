using System;
using System.Collections.Generic;
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
using Microsoft.Win32;

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for PalyaBetoltoWindow.xaml
    /// </summary>
    public partial class PalyaBetoltoWindow : Window
    {
        public PalyaBetoltoWindow()
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

        private void btnUj_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));
            btnUj.Foreground = myVerticalGradient;
        }

        private void btnUj_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));
            btnUj.Foreground = myVerticalGradient;
        }

        private void btnTallozas_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));
            btnTallozas.Foreground = myVerticalGradient;
        }

        private void btnTallozas_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));
            btnTallozas.Foreground = myVerticalGradient;
        }

        private void btnUj_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = File.CreateText("load.txt"))
            {
                writer.WriteLineAsync("");
                writer.Close();
            }
            GameWindow openGame = new GameWindow();
            openGame.Show();
            this.Close();
        }

        private void btnTallozas_Click(object sender, RoutedEventArgs e)
        {
            string fajlNev = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            while (fajlNev == "")
            {
                try
                {
                    if (openFileDialog.ShowDialog() == true)
                        fajlNev = openFileDialog.FileName;
                }
                catch (Exception)
                {

                    MessageBox.Show("A fájl kiválasztása közben hiba történt");
                }

            }


            using (StreamWriter writer = File.CreateText("load.txt"))
            {
                writer.WriteLineAsync(fajlNev);
                writer.Close();
            }
            GameWindow openGame = new GameWindow();
            openGame.Show();
            this.Close();
        }
    }
}
