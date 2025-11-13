using System.Drawing;

public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public string SetColor(string NewColor)
    {
        return _color = NewColor;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}