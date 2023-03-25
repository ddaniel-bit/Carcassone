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
            LinearGradientBrush myVerticalGradient = MouseEnterColor();
            btnStart.Foreground = myVerticalGradient;

        }

        private void btnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = MouseLeaveColor();
            btnStart.Foreground = myVerticalGradient;
        }

        private void btnSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = MouseEnterColor();
            btnSettings.Foreground = myVerticalGradient;
        }

        private void btnSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = MouseLeaveColor();
            btnSettings.Foreground = myVerticalGradient;
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = MouseEnterColor();
            btnExit.Foreground = myVerticalGradient;
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            LinearGradientBrush myVerticalGradient = MouseLeaveColor();
            btnExit.Foreground = myVerticalGradient;
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
    }
}
