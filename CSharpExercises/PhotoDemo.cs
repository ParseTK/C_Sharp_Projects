using System;
using static System.Console;
using System.Globalization;
/*
Create an application class named PhotoDemo that demonstrates the methods of three related classes for a company that develops photographs.

Create a class named Photo that includes fields for width andheight in inches and properties for each field. 
The class should contain get and set accessors named Width and Height respectively.

Include a protected price field, and set it to $3.99 for an 8-inch by 10-inch photo, $5.99 for a 10-inch by 12-inch photo, and 
$9.99 for any other size (because custom cutting is required). The price field requires a get accessor but no set accessor.

Also include a ToString() method that returns a string constructed from the return value of the object’s GetType() method and the values of the fields.

Derive two subclasses— MattedPhoto and FramedPhoto.

The MattedPhoto class includes a string field named Color to hold a color, and 
the FramedPhoto class includes two string fields that hold the frame’s material (such as silver) and style (such as modern), named Material and Style respectively.

Use default, empty constructor.

The price for a MattedPhoto increases by $10 over its base cost, and the price for a FramedPhoto increases by $25 over its base cost. 
Each subclass should include a ToString() method that overrides the parent class version.
*/
class PhotoDemo
{
    static void Main()
    {
        Photo photo = new Photo(8, 10);
        Photo photo1 = new Photo(); // using default constructor
        photo1.Width = 8;
        photo1.Height = 9;

        MattedPhoto matted = new MattedPhoto(10, 12, "white matting");
        FramedPhoto framed = new FramedPhoto(8, 10, "silver", "modern");

        WriteLine(photo);
        WriteLine(photo1);
        WriteLine(matted);
        WriteLine(framed);
    }
}

public class Photo
{
    private int width;
    private int height;
    protected double basePrice;

    public int Width { get => width; set => width = value; }
    public int Height { get => height; set => height = value; }

    public virtual double Price
    {
        get
        {
            if (basePrice == 0.0)
            {
                basePrice = (Width, Height) switch
                {
                    (8, 10) => 3.99,
                    (10, 12) => 5.99,
                    _ => 9.99
                };
            }
            return basePrice;
        }
    }

    public Photo() { }

    public Photo(int _width, int _height)
    {
        width = _width;
        height = _height;

        basePrice = (_width, _height) switch
        {
            (8, 10) => 3.99,
            (10, 12) => 5.99,
            _ => 9.99
        };
    }

    public override string ToString()
    {
        return $"{GetType().Name}    {Width} X {Height}   Price: {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}

public class MattedPhoto : Photo
{
    private string color;
    public string Color { get => color; set => color = value; }

    public MattedPhoto() { }

    public MattedPhoto(int _width, int _height, string _color) : base(_width, _height)
    {
        color = _color;
    }

    public override double Price => base.Price + 10;

    public override string ToString()
    {
        return $"{GetType().Name}    {Color} {Width} X {Height}   Price: {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}

public class FramedPhoto : Photo
{
    private string material;
    private string style;

    public string Material { get => material; set => material = value; }
    public string Style { get => style; set => style = value; }

    public FramedPhoto() { }

    public FramedPhoto(int _width, int _height, string _material, string _style) : base(_width, _height)
    {
        material = _material;
        style = _style;
    }

    public override double Price => base.Price + 25;

    public override string ToString()
    {
        return $"{GetType().Name}    {Style}, {Material} frame. {Width} X {Height}   Price: {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}
