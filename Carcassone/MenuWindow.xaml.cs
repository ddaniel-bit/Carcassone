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
        public MenuWindow()
        {
            InitializeComponent();
            beallitasok = sr.ReadLine().Split(";");
            sr.Close();
            if (bool.Parse(beallitasok[0]))
            {
                lbZene.Content = "Be";
            }
            else
            {
                lbZene.Content = "Ki";
            }
            sliHangero.Value = double.Parse(beallitasok[1]);
            
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
        }

        private void btnKi_Click(object sender, RoutedEventArgs e)
        {
            lbZene.Content = "Ki";
            btnBe.Opacity = 1;
            btnKi.Opacity = 0.5;
            beallitasok[0] = "false";

        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            beallitasok[1] = sliHangero.Value.ToString();

            using (StreamWriter writer = File.CreateText("settings.txt"))
            {
                writer.WriteLineAsync(beallitasok[0] + ";" + beallitasok[1]);
                writer.Close();
            }

            MainWindow openMain = new MainWindow();
            openMain.Show();
            this.Close();         
        }
        private void asd_Click(object sender, RoutedEventArgs e)
        {


            SummaryWindow openSummary = new SummaryWindow();
            openSummary.ShowDialog();


        }
    }
}
