using System;

interface IDisplay
{
    void Display();
}

class Shape
{
    public virtual void DisplayInformation()
    {
        Console.WriteLine("Це фігура.");
    }

    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape, IDisplay
{
    public double Radius { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Це коло з радіусом {Radius}.");
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Display()
    {
        Console.WriteLine("Коло відображено.");
    }
}

class Rectangle : Shape, IDisplay
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Це прямокутник з довжиною {Length} і шириною {Width}.");
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public void Display()
    {
        Console.WriteLine("Прямокутник відображено.");
    }
}

class Triangle : Shape, IDisplay
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Це трикутник з основою {Base} і висотою {Height}.");
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public void Display()
    {
        Console.WriteLine("Трикутник відображено.");
    }
}

class Square : Shape, IDisplay
{
    public double Side { get; set; }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Це квадрат зі стороною {Side}.");
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }

    public void Display()
    {
        Console.WriteLine("Квадрат відображено.");
    }
}

class Program
{
    static void Main()
    {
        // Введення параметрів для кожної фігури
        Console.Write("Введіть радіус кола: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину прямокутника: ");
        double rectangleLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть ширину прямокутника: ");
        double rectangleWidth = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть основу трикутника: ");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть висоту трикутника: ");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони квадрата: ");
        double squareSide = Convert.ToDouble(Console.ReadLine());

        // Створення об'єктів для кожної фігури
        Circle circle = new Circle { Radius = circleRadius };
        Rectangle rectangle = new Rectangle { Length = rectangleLength, Width = rectangleWidth };
        Triangle triangle = new Triangle { Base = triangleBase, Height = triangleHeight };
        Square square = new Square { Side = squareSide };

        // Виклик методів для виведення інформації
        circle.DisplayInformation();
        circle.Display();
        Console.WriteLine($"Площа кола: {circle.CalculateArea()}");

        Console.WriteLine();

        rectangle.DisplayInformation();
        rectangle.Display();
        Console.WriteLine($"Площа прямокутника: {rectangle.CalculateArea()}");

        Console.WriteLine();

        triangle.DisplayInformation();
        triangle.Display();
        Console.WriteLine($"Площа трикутника: {triangle.CalculateArea()}");

        Console.WriteLine();

        square.DisplayInformation();
        square.Display();
        Console.WriteLine($"Площа квадрата: {square.CalculateArea()}");
    }
}
