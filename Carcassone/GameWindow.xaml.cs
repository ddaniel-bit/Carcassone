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
using System.Windows.Documents.DocumentStructures;
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
        bool elsolape = true;
        string[,] UrikTarolva = new string[5, 8];


        Uri hoversound = new Uri("hoversound.mp3", UriKind.RelativeOrAbsolute);
        MediaPlayer hoverplayer = new MediaPlayer();

        LinearGradientBrush GradientColor1 = new LinearGradientBrush();
        LinearGradientBrush GradientColor2 = new LinearGradientBrush();

        public GameWindow()
        {
            InitializeComponent();
            UrikTaroloFeltoltes();
            BetoltGombokat();
            LapValasztas();

        }

        private void LapValasztas()
        {
            randomlap = filePaths[vel.Next(50)];
            preview.Source = new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative));
        }

        private void BetoltGombokat()
        {
            //szinek
            GradientColor1.StartPoint = new Point(0.5, 0);
            GradientColor1.EndPoint = new Point(0.5, 1);
            GradientColor1.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 0.0));
            GradientColor1.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 1.0));

            GradientColor2.StartPoint = new Point(0.5, 0);
            GradientColor2.EndPoint = new Point(0.5, 1);
            GradientColor2.GradientStops.Add(
                new GradientStop(Color.FromRgb(181, 99, 74), 0.0));
            GradientColor2.GradientStops.Add(
                new GradientStop(Color.FromRgb(255, 229, 92), 1.0));

            for (int sorIndex = 0; sorIndex < 5; sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                {
                    Button ujgomb = new Button();
                    //ujgomb.Background = Brushes.Transparent;
                    ujgomb.Opacity = 0.2;
                    ujgomb.Cursor = Cursors.Hand;



                    if (oszlopIndex % 2 == 0)
                    {
                        ujgomb.Background = GradientColor1;
                    }
                    else
                    {
                        ujgomb.Background = GradientColor2;
                    }

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


            if ((b.Background == GradientColor1 || b.Background == GradientColor2) && SzabalyosLerakas(sor, oszlop))
            {
                Style Temp;
                Temp = (Style)this.FindResource("ButtonStyleHover");
                b.Style = Temp;
                b.Opacity = 1;
                b.Cursor = Cursors.Arrow;
                b.BorderBrush = Brushes.Transparent;

                b.Background = new ImageBrush(new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative)));
                UrikTarolva[sor - 1, oszlop - 1] = randomlap;
                hoverplayer.Open(hoversound);
                hoverplayer.Play();

                //       MessageBox.Show(UrikTarolva[sor -1, oszlop - 1][14].ToString());
                LapValasztas();
                string vaneures = "0";
                for (int sorIndex = 0; sorIndex < 5; sorIndex++)
                {
                    for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                    {
                        if (UrikTarolva[sorIndex, oszlopIndex] == "")
                        {
                            vaneures += "1";
                        }
                    }
                }
                string randomlaperedeti = randomlap;
                if (!vaneures.Contains("1"))
                {
                    int[] pontok = Pontozas(true);
                    MessageBox.Show("Ennyi pontot kaptál összesen: " + Convert.ToString(pontok[0] + pontok[1] + pontok[2] + pontok[3]) + ". Kolostorokból: " + Convert.ToString(pontok[0]) + " Városokból: " + Convert.ToString(pontok[1]) + " Utakból: " + Convert.ToString(pontok[2]) + " Pluszpontokból: " + pontok[3]);
                }
                else if (JatekVege())
                {
                    randomlap = @".\img\kartyak\" + randomlap[17] + randomlap[14] + randomlap[15] + randomlap[16] + randomlap[18] + randomlap[19] + ".png";
                    if (JatekVege())
                    {
                        randomlap = @".\img\kartyak\" + randomlap[16] + randomlap[17] + randomlap[14] + randomlap[15] + randomlap[18] + randomlap[19] + ".png";
                        if (JatekVege())
                        {
                            randomlap = @".\img\kartyak\" + randomlap[15] + randomlap[16] + randomlap[17] + randomlap[14] + randomlap[18] + randomlap[19] + ".png";
                            if (JatekVege())
                            {
                                MessageBox.Show("Na en veled nem jatszok.");
                                int[] pontok = Pontozas(false);
                                MessageBox.Show("Ennyi pontot kaptál összesen: " + Convert.ToString(pontok[0] + pontok[1] + pontok[2] + pontok[3]) + ". Kolostorokból: " + Convert.ToString(pontok[0]) + " Városokból: " + Convert.ToString(pontok[1]) + " Utakból: " + Convert.ToString(pontok[2]) + " Pluszpontokból: " + pontok[3]);
                            }
                        }
                    }
                }
                randomlap = randomlaperedeti;
            }



        }

        private bool JatekVege()
        {
            List<string> uresmezoktarolo = new List<string>();
            for (int sorIndex = 0; sorIndex < UrikTarolva.GetLength(0); sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < UrikTarolva.GetLength(1); oszlopIndex++)
                {
                    if (UrikTarolva[sorIndex, oszlopIndex] == "")
                    {
                        uresmezoktarolo.Add(sorIndex + "," + oszlopIndex);
                    }
                }

            }

            foreach (var item in uresmezoktarolo)
            {
                string[] tomb = item.Split(',');

                int sor = int.Parse(tomb[0]);
                int oszlop = int.Parse(tomb[1]);

                if (SzabalyosLerakas(sor + 1, oszlop + 1))
                {
                    return false;
                }

            }
            return true;

        }

        private bool SzabalyosLerakas(int sor, int oszlop)
        {

            bool szabalyos = false;
            if (UrikTarolva[sor - 1, oszlop - 1] == "")
            {
                if (elsolape && sor != 1 && sor != 5 && oszlop != 1 && oszlop != 8 &&
                    UrikTarolva[sor - 1, oszlop - 2].ToString() == ""
                && UrikTarolva[sor - 1, oszlop].ToString() == ""
                && UrikTarolva[sor - 2, oszlop - 1].ToString() == ""
                && UrikTarolva[sor, oszlop - 1].ToString() == "") // azt vizsgálja, hogy az első letett kártya-e
                {
                    szabalyos = true;
                    elsolape = false;
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


                    if (!szabalyos_ell.Contains("1") && vizsg != "")
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


        private int[] Pontozas(bool betelte)
        {
            int[] kvub_pontok = new int[4];
            //megkeresi az összes kolostort és egyenként pontoz
            int kolostorpont = 0; //a kolostorokból kapott pontok
            for (int sorIndex = 0; sorIndex < 5; sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                {
                    if (UrikTarolva[sorIndex, oszlopIndex] != "")
                    {
                        if (UrikTarolva[sorIndex, oszlopIndex][19] == 'k')
                        {
                            if (sorIndex != 4 && oszlopIndex != 7 && UrikTarolva[sorIndex + 1, oszlopIndex + 1] != "")
                            {
                                kolostorpont++;
                            }
                            if (sorIndex != 0 && oszlopIndex != 0 && UrikTarolva[sorIndex - 1, oszlopIndex - 1] != "")
                            {
                                kolostorpont++;
                            }
                            if (sorIndex != 4 && oszlopIndex != 0 && UrikTarolva[sorIndex + 1, oszlopIndex - 1] != "")
                            {
                                kolostorpont++;
                            }
                            if (sorIndex != 0 && oszlopIndex != 7 && UrikTarolva[sorIndex - 1, oszlopIndex + 1] != "")
                            {
                                kolostorpont++;
                            }
                            if (sorIndex != 4 && UrikTarolva[sorIndex + 1, oszlopIndex] != "")
                            {
                                kolostorpont++;
                            }
                            if (sorIndex != 0 && UrikTarolva[sorIndex - 1, oszlopIndex] != "")
                            {
                                kolostorpont++;
                            }
                            if (oszlopIndex != 7 && UrikTarolva[sorIndex, oszlopIndex + 1] != "")
                            {
                                kolostorpont++;
                            }
                            if (oszlopIndex != 0 && UrikTarolva[sorIndex, oszlopIndex - 1] != "")
                            {
                                kolostorpont++;
                            };
                        }
                    }
                }
            }

            //varosok pontozasa
            int varospont = 0; //a városokból kapott pontok
            for (int sorIndex = 0; sorIndex < 5; sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                {
                    if (UrikTarolva[sorIndex, oszlopIndex] != "")
                    {

                        if (UrikTarolva[sorIndex, oszlopIndex].Substring(14, 4).Contains("v"))
                        {
                            varospont += 2;
                        };
                    }
                }
            }

            //varosok pontozasa
            int utpont = 0; //az utakból kapott pontok
            for (int sorIndex = 0; sorIndex < 5; sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < 8; oszlopIndex++)
                {
                    if (UrikTarolva[sorIndex, oszlopIndex] != "")
                    {

                        if (UrikTarolva[sorIndex, oszlopIndex].Substring(14, 4).Contains("u"))
                        {
                            utpont += 1;
                        }
                    }
                }
            }

            //ha betelt a terület hozzáad +10 pontot
            int pluszpont = 0;
            if (betelte)
            {
                pluszpont = +10;
            }
            kvub_pontok[0] = kolostorpont;
            kvub_pontok[1] = varospont;
            kvub_pontok[2] = utpont;
            kvub_pontok[3] = pluszpont;
            return kvub_pontok;
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
        //forgatas gombok:
        private void RotateRight_Click_1(object sender, RoutedEventArgs e)
        {

            randomlap = @".\img\kartyak\" + randomlap[17] + randomlap[14] + randomlap[15] + randomlap[16] + randomlap[18] + randomlap[19] + ".png";
            preview.Source = new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative));
            //14,15,16,17_19
        }

        private void RotateLeft_Click(object sender, RoutedEventArgs e)
        {
            randomlap = @".\img\kartyak\" + randomlap[15] + randomlap[16] + randomlap[17] + randomlap[14] + randomlap[18] + randomlap[19] + ".png";
            preview.Source = new BitmapImage(new Uri(@$"{randomlap}", UriKind.Relative));
        }

        private void btnKiertekeles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnKiertekeles_MouseEnter(object sender, MouseEventArgs e)
        {
            btnKiertekeles.Foreground = MouseEnterColor();
        }

        private void btnKiertekeles_MouseLeave(object sender, MouseEventArgs e)
        {
            btnKiertekeles.Foreground = MouseLeaveColor();
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




    }
}

