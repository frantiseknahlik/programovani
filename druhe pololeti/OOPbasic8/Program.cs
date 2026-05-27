List<Shape> shapes =
[
    new Rectangle(3.0, 2.0),
    new Circle(4.0),
];

foreach (var shape in shapes)
{
    Console.WriteLine($"Obsah: {shape.CalculateArea()}");
    Console.WriteLine($"Obvod: {shape.CalculatePerimeter()}");
    Console.WriteLine();
}

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}

class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double CalculateArea()
    {
        return _width * _height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (_width + _height);
    }
}