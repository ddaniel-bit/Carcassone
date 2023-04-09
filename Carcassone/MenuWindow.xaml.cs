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
using System.Windows.Shapes;

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
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
        private void btnTalcaraTesz_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnBe_Click(object sender, RoutedEventArgs e)
        {
            lbZene.Content = "Be";
            btnBe.Opacity = 0.5;
            btnKi.Opacity = 1;
        }

        private void btnKi_Click(object sender, RoutedEventArgs e)
        {
            lbZene.Content = "Ki";
            btnBe.Opacity = 1;
            btnKi.Opacity = 0.5;

        }
    }
}
