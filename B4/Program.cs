using System;
namespace B4
{
    public class Shape
    {
        public virtual double GetArea() { return 0; }
        public virtual bool IsLegal() { return false; }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double l = 1, double w = 1)
        {
            length = l;
            width = w;
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override bool IsLegal()
        {
            return length > 0 && width > 0;
        }
        public override double GetArea()
        {
            return length * width;
        }
    }
    public class Square : Shape
    {
        private double side;
        public Square(double s = 1)
        {
            side = s;
        }
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public override bool IsLegal()
        {
            return side > 0;
        }
        public override double GetArea()
        {
            return side * side;
        }

    }
    public class Triangle : Shape
    {
        private double a, b, c;
        public Triangle(double a = 1, double b = 3, double c = 3)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override bool IsLegal()
        {
            return (a + b > c) && (a + c > b) && (b + c) > a;
        }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    public class Test
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(8, 4);
            Square square = new Square(3);
            Triangle triangle = new Triangle(2, 3, 4);

            if (rectangle.IsLegal())
            {
                Console.WriteLine("长方形宽：{0},长：{1}，面积：{2}", rectangle.Width, rectangle.Length, rectangle.GetArea());
            }
            else { throw new ArgumentException("不是长方形！"); }
            if (square.IsLegal())
            {
                Console.WriteLine("正方形边长：{0}，面积：{1}", square.Side, square.GetArea());
            }
            else { throw new ArgumentException("不是正方形！"); }
            if (rectangle.IsLegal())
            {
                Console.WriteLine("三角形的面积：{0}", triangle.GetArea());
            }
            else { throw new ArgumentException("不是三角形！"); }
            Console.ReadKey();
        }
    }
}
