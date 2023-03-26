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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {

        

        public GameWindow()
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

        
    }

    public class Cards
    {
        char left;
        char right;
        char top;
        char bottom;
        char center;
        string bgImage;

        public Cards(char left, char right, char top, char bottom, char center, string bgImage)
        {
            this.Left = left;
            this.Right = right;
            this.Top = top;
            this.Bottom = bottom;
            this.Center = center;
            this.BgImage = bgImage;
        }

        public char Left { get => left; }
        public char Right { get => right; }
        public char Top { get => top; }
        public char Bottom { get => bottom; }
        public char Center { get => center; }
        public char BgImage { get => bgImage; }

        public void Rotate(Cards card, bool direction) //direction = True => Jobbra forgatás,		direction = False => Balra forgatás.
        {
            //todo Rotate függvény megírása
        }
    }

}
