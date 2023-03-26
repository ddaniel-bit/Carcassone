using System;

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

	public void Rotate(Cards card, bool direction) //direction = True => Jobbra forgatás,		direction = False => Balra forgatás.
	{
		//todo Rotate függvény megírása
	}

}
