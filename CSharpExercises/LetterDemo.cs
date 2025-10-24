using System;
using static System.Console;
using System.Globalization;
/*
Create an application class named LetterDemo 
that instantiates objects of two classes named Letter and CertifiedLetter and that demonstrates all their methods.

The classes are used by a company to keep track of letters they mail to clients. 
The Letter class includes auto-implemented properties for the Name of the recipient and the Date mailed (stored as strings).

Create a child class named CertifiedLetter that includes an auto-implemented property 
TrackingNumber (of type string) that holds a tracking number for the letter.

Next, include a ToString() method that overrides the Object class’s ToString() method and returns a string that contains the name of the class (using GetType()) and 
the respective class's data field values. Use default, empty constructor for both classes.
*/
class LetterDemo
{
	static void Main()
	{
		Letter letter = new Letter();
		CertifiedLetter certLetter = new CertifiedLetter();
	}
}

public class Letter
{
	public string Name { get; set; }
	public string Date { get; set; }

	public Letter() { }
	public override string ToString()
	{
		string temp = $"{GetType()}: Name = {Name}, Date = {Date}";
		return temp;
	}
}

public class CertifiedLetter : Letter
{
    public string TrackingNumber { get; set; }

	public CertifiedLetter() { }
	public override string ToString()
	{
		string temp = $"{GetType()}: Name >> {Name}, Date >> {Date}, Tracking Number >> {TrackingNumber}";
		return temp;
	}
}
