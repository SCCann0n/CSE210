using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        Square s1 = new Square("Blue", 2.25);
        shapesList.Add(s1);

        Rectangle r1 = new Rectangle("Green", 3, 4);
        shapesList.Add(r1);

        Circle c1 = new Circle("Yellow", 5);
        shapesList.Add(c1); 

        foreach (Shape s in shapesList)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The shape is the color {color}, and has an area of {area}");
        }
    }
}