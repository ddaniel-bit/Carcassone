using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Carcassone
{
    public class Cards
    {
        char left;
        char right;
        char top;
        char bottom;
        char center;
        string bgImage;

        public Cards(string bgImage)
        {
            this.bgImage = bgImage;
            string imgPath = bgImage.Remove(0, 14); //leszedi a "\img\kartyak\" részt
            this.left = imgPath[0];
            this.top = imgPath[1];
            this.right = imgPath[2];
            this.bottom = imgPath[3];
            this.center = imgPath[5];
        }

        public char Left { get => left; }
        public char Right { get => right; }
        public char Top { get => top; }
        public char Bottom { get => bottom; }
        public char Center { get => center; }
        public string BgImage { get => bgImage; }
        public void Info()
        {
            MessageBox.Show($"{left}, {top}, {right}, {bottom}, {center}, {bgImage}");
        }

        public void Rotate(bool direction) //direction = True => Jobbra forgatás,		direction = False => Balra forgatás.
        {
            //todo Rotate függvény megírása
            string temp = BgImage.Remove(0, 14);        //leszedi a "\img\kartyak\" részt
            temp.Remove(4);                             // leszedi a "_center.png" részt 
            switch (direction)
            {
                case true:
                    this.left = temp[3];
                    this.top = temp[0];
                    this.right = temp[1];
                    this.bottom = temp[2];
                    break;
                case false:
                    this.left = temp[1];
                    this.top = temp[2];
                    this.right = temp[3];
                    this.bottom = temp[0];
                    break;
                default:
                    break;
            }
            this.bgImage = @$"\img\kartyak\{left}{top}{right}{bottom}_{center}.png";
        }
    }
}
