using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xaml;

namespace Carcassone
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Random vel = new Random();
        string[] filePaths = Directory.GetFiles(@".\img\kartyak\", "*.png", SearchOption.TopDirectoryOnly);
        string randomlap;
        string[,] UrikTarolva = new string[5, 8];


        Uri hoversound = new Uri("hoversound.mp3", UriKind.RelativeOrAbsolute);
        MediaPlayer hoverplayer = new MediaPlayer();


        public GameWindow()
        {
            InitializeComponent();
            UrikTaroloFeltoltes();
            BetoltGombokat();
            LapValasztas();
        }

        private void LapValasztas()
        {
            randomlap = filePaths[vel.Next(23)];
            preview.Source = new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative));
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
                    ujgomb.Name = "btn" + sorIndex.ToString() + "_" + oszlopIndex.ToString();
                    ujgomb.Click += gombClick;
                    Grid.SetRow(ujgomb, sorIndex + 1);
                    Grid.SetColumn(ujgomb, oszlopIndex + 1);
                    this.gameGrid.Children.Add(ujgomb);
                }

            }
        }
        private void UrikTaroloFeltoltes()
        {
            for (int sorIndex = 0; sorIndex < UrikTarolva.GetLength(0); sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < UrikTarolva.GetLength(1); oszlopIndex++)
                {
                    UrikTarolva[sorIndex, oszlopIndex] = "";
                }

            }
        }






        private void gombClick(object sender, RoutedEventArgs e)
        {

            Button b = sender as Button;
            int sor = Grid.GetRow(b);
            int oszlop = Grid.GetColumn(b);


            lblDebug.Content = sor + " " + oszlop;


            //       b.IsEnabled = false;

            //      Canvas can = new Canvas();
            //      Grid.SetRow(can, sor);
            //      Grid.SetColumn(can, oszlop);
            //     MessageBox.Show(randomlap[14].ToString());
            //      MessageBox.Show(oszlop.ToString());


            if (b.Background.ToString() == "#FFDDDDDD" && SzabalyosLerakas(b, sor, oszlop))
            {
                Style Temp;
                Temp = (Style)this.FindResource("ButtonStyleHover");
                b.Style = Temp;
                b.Opacity = 1;

                b.Background = new ImageBrush(new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative)));
                UrikTarolva[sor - 1, oszlop - 1] = randomlap;
                hoverplayer.Open(hoversound);
                hoverplayer.Play();

                //       MessageBox.Show(UrikTarolva[sor -1, oszlop - 1][14].ToString());
                LapValasztas();

            }


            //     this.gameGrid.Children.Add(can);

        }

        private bool SzabalyosLerakas(Button btn, int sor, int oszlop)
        {

            bool szabalyos = false;
            if (UrikTarolva[sor - 1, oszlop - 1] == "")
            {

                if (sor != 1 && sor != 5 && oszlop != 1 && oszlop != 8 &&
                    UrikTarolva[sor - 1, oszlop - 2].ToString() == ""
                && UrikTarolva[sor - 1, oszlop].ToString() == ""
                && UrikTarolva[sor - 2, oszlop - 1].ToString() == ""
                && UrikTarolva[sor, oszlop - 1].ToString() == "") // azt vizsgálja, hogy az első letett kártya-e
                {
                    szabalyos = true;
                }
                else
                {
                    string vizsg = "";
                    string szabalyos_ell = "";
                    if (oszlop != 1 && UrikTarolva[sor - 1, oszlop - 2].ToString() != "")
                    {
                        vizsg += "b";
                    }
                    if (oszlop != 8 && UrikTarolva[sor - 1, oszlop].ToString() != "")
                    {
                        vizsg += "j";
                    }
                    if (sor != 1 && UrikTarolva[sor - 2, oszlop - 1].ToString() != "")
                    {
                        vizsg += "f";
                    }
                    if (sor != 5 && UrikTarolva[sor, oszlop - 1].ToString() != "")
                    {
                        vizsg += "l";
                    }



                    if (vizsg.Contains("b"))
                    {
                        if (oszlop != 1 && UrikTarolva[sor - 1, oszlop - 2][16] == randomlap[14])
                        {
                            szabalyos_ell += "0";
                        }
                        else
                        {
                            szabalyos_ell += "1";
                        }
                    }
                    if (vizsg.Contains("j"))
                    {
                        if (oszlop != 8 && UrikTarolva[sor - 1, oszlop][14] == randomlap[16])
                        {
                            szabalyos_ell += "0";
                        }
                        else
                        {
                            szabalyos_ell += "1";
                        }
                    }
                    if (vizsg.Contains("f"))
                    {
                        if (sor != 1 && UrikTarolva[sor - 2, oszlop - 1][17] == randomlap[15])
                        {
                            szabalyos_ell += "0";
                        }
                        else
                        {
                            szabalyos_ell += "1";
                        }
                    }
                    if (vizsg.Contains("l"))
                    {
                        if (sor != 5 && UrikTarolva[sor, oszlop - 1][15] == randomlap[17])
                        {
                            szabalyos_ell += "0";
                        }
                        else
                        {
                            szabalyos_ell += "1";
                        }
                    }


                    if (!szabalyos_ell.Contains("1"))
                    {
                        szabalyos = true;
                    }
                }



            }
            else
            {
                szabalyos = false;
            }
            return szabalyos;

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

        private void Border_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    Close();
                    break;
                default:
                    break;
            }
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

        public Cards(char left, char right, char top, char bottom, char center)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
            this.center = center;
            //   this.bgImage = left.ToString() +  top.ToString() + right.ToString() + bottom.ToString() + "_" + center.ToString()+".png";
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
