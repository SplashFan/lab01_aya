//Задание №1
        Console.WriteLine("Задание № 1\n");
        Console.WriteLine("Максимальное значение int: " + int.MaxValue +
        "\nМинимальное значение int: " + int.MinValue +
        "\nМаксимальное значение float: " + float.MaxValue +
        "\nМинимальное значение float: " + float.MinValue +
        "\nМаксимальное значение char: " + char.MaxValue +
        "\nМинимальное значение char: " + char.MinValue +
        "\nМаксимальное значение bool: " + true +
        "\nМинимальное значение bool: " + false);

//Задание №2

Console.WriteLine("\nЗадание №2");
Console.WriteLine("\nВведите длину первой стороны прямоугольника: ");
double sideA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nВведите длину второй стороны прямоугольника: ");
double sideB = Convert.ToDouble(Console.ReadLine());
var rectangle = new Rectangle(sideA, sideB);
Console.WriteLine("Площадь прямоугольника: {0}, Периметр прямоугольника: {1}", rectangle.Area, rectangle.Perimeter);

//Задание №3
Console.WriteLine("\n Задание №3");
var p1 = new Point(4, 6);
var p2 = new Point(3, 5);
var p3 = new Point(8, 2);
var p4 = new Point(5, 9);
var p5 = new Point(4, 3);

var triangle = new Figure(p1, p2, p3);
Console.WriteLine(triangle.Name + " с периметром " + triangle.Per);

var rectangle_2 = new Figure(p1, p2, p3, p4);
Console.WriteLine(rectangle_2.Name + " с периметром " + rectangle_2.Per);

var pentagon = new Figure(p1, p2, p3, p4, p5);
Console.WriteLine(pentagon.Name + " с периметром " + pentagon.Per);


class Rectangle
{
    double side1, side2;
    public Rectangle(double sideA, double sideB)
    {
        this.side1 = sideA;
        this.side2 = sideB;
    }

    private double CalculateArea(double side1, double side2)
    {
        return side1 * side2;
    }

    private double CalculatePerimeter(double side1, double side2)
    {
        return 2*(side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(side1, side2); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(side1, side2); }
    }
}

class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int x_cord
    {
        get { return x; }
    }
    public int y_cord
    {
        get { return y; }
    }
}

class Figure
{
    Point p1, p2, p3, p4, p5;
    public string Name;
    public double per;
    public Figure(Point p1, Point p2, Point p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        Name = "Треугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4):this(p1, p2, p3)
    {
        this.p4 = p4;
        Name = "Четырехугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5):this(p1, p2, p3, p4)
    {
        this.p5 = p5;
        Name = "Пятиугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(A.x_cord - B.x_cord, 2.0) + Math.Pow(A.y_cord - B.y_cord, 2.0));
    }
    public double PerimeterCalculator(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        per = LengthSide(p1, p2) + LengthSide(p2, p3);
        if (Name == "Треугольник")
        {
            per += LengthSide(p3, p1);
        }
        else if (Name == "Четырехугольник")
        {
            per += LengthSide(p4, p3) + LengthSide(p1, p4);
        }
        else
        {
            per += LengthSide(p5, p1) + LengthSide(p3, p4) + LengthSide(p4, p5);
        }
        return per;
    }
    public double Per
    {
        get { return PerimeterCalculator(p1, p2, p3, p4, p5); }
    }
}