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
            BetoltGombokat();
        }

        private void BetoltGombokat()
        {
            for (int sorIndex = 0; sorIndex < 5; sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                {
                    Button ujgomb = new Button();
                    //ujgomb.Background = Brushes.Transparent;
                    ujgomb.Opacity = 0.2;
                    ujgomb.Cursor = Cursors.Hand;
                    ujgomb.Name = "btn"+sorIndex.ToString()+"_"+oszlopIndex.ToString();
                    ujgomb.Click += gombClick;
                    Grid.SetRow(ujgomb, sorIndex+1);
                    Grid.SetColumn(ujgomb, oszlopIndex+1);
                    this.gameGrid.Children.Add(ujgomb);
                }
             
            }
        }

        private void gombClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int sor = Grid.GetRow(b);
            int oszlop = Grid.GetColumn(b);
            b.Focusable = false;
            b.Opacity = 1;
            //b.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\tanulo\source\repos\Carcassone\Carcassone\Carcassone\img\kartyak\kolostor.png", UriKind.Relative)));
            b.Background = new ImageBrush(new BitmapImage(new Uri(@"./img/kartyak/kolostor.png", UriKind.Relative)));
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
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
            this.center = center;
            this.bgImage = bgImage;
        }

        public char Left { get => left; }
        public char Right { get => right; }
        public char Top { get => top; }
        public char Bottom { get => bottom; }
        public char Center { get => center; }
        public string BgImage { get => bgImage; }

        public void Rotate(Cards card, bool direction) //direction = True => Jobbra forgatás,		direction = False => Balra forgatás.
        {
            //todo Rotate függvény megírása
        }
    }

}
