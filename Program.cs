using System.Threading.Channels;

public abstract class Shape
{
    public abstract int Area();
    public abstract int Perimeter();

}
public class Rectangle : Shape
{
    private int width;
    private int length;

    public Rectangle(int width, int length)
    {
        this.width = width;
        this.length = length;
    }

    public override int Area()
    {
        return width * length;
    }
    public override int Perimeter()
    {
        return 2 * (width + length);
    }
    public override string ToString()
    {
        return $"Rectangle area: " + Area() + "\nPerimeter: " + Perimeter();
    }
}

public class Square : Rectangle
{

    public Square(int width, int length) : base(width, length) { length = 4; }
    public override int Area()
    {
        return base.Area();
    }

    public override int Perimeter()
    {
        return base.Perimeter();

    }

    public override string ToString()
    {
        return $"Square area: " + Area() + "\nPerimeter: " + Perimeter();
    }
}

public class Circle : Shape
{
    private int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override int Area()
    {
        return 2 * radius * 3;

    }
    public override int Perimeter()
    {
        return 2 * radius * 3;
    }

    public override string ToString()
    {
        return $"Circle area: " + Area() + "\nPerimeter: " + Perimeter();
    }
}
class Program
{
    static void Main(string[] args)
    {
        int width = 5;
        int length = 2;
        int radius = 3;

        Shape shape = new Rectangle(width, length);
        Shape shape1 = new Square(length, width);
        Shape shape2 = new Circle(radius);

        shape.Area();
        shape.Perimeter();
        Console.WriteLine(shape.ToString());

        shape1.Perimeter();
        shape1.Area();
        Console.WriteLine(shape1.ToString());

        shape2.Perimeter();
        shape2.Area();
        Console.WriteLine(shape2.ToString());
    }
}
