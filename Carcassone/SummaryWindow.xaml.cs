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

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for SummaryWindow.xaml
    /// </summary>
    public partial class SummaryWindow : Window
    {
        int osszpont;
        public SummaryWindow()
        {
            InitializeComponent();
            Pontozas();
            Rekord();
        }

        private void Rekord()
        {
            StreamReader sr = new StreamReader("record.txt");
            int record = sr.Read()-48;
            sr.Close();
            if (osszpont > record)
            {
                using (StreamWriter writer = File.CreateText("record.txt"))
                {
                    writer.WriteLineAsync(osszpont.ToString());
                    writer.Close();
                }
            }
        }

        private void Pontozas()
        {
            StreamReader sr = new StreamReader("summary.txt");
            string[] Pontozasok = sr.ReadLine().Split(";");
            sr.Close();
            lbKolostorokpont.Content = Pontozasok[1];
            lbVarosreszekpont.Content = Pontozasok[2];
            lbUtreszekpont.Content = Pontozasok[3];
            lbBefejezettpalyapont.Content = Pontozasok[4];
            lbOsszesenpont.Content = Pontozasok[0];
            osszpont =int.Parse(Pontozasok[0]);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btntovabb_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));
            btntovabb.Foreground = myVerticalGradient;
        }

        private void btntovabb_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));
            btntovabb.Foreground= myVerticalGradient;
        }

        private void btntovabb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
