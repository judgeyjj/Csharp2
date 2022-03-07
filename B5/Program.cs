using System;

namespace B5
{
    interface Graph
    {
        double GetArea();
        bool IsRight();
    }
    class Rectangle : Graph
    {
        private double x, y;
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetArea()
        {
            return x * y;
        }
        public bool IsRight()
        {
            return x > 0 && y > 0;
        }
    }
    class Square : Graph
    {
        private double x;
        public Square(double x)
        {
            this.x = x;
        }
        public double GetArea()
        {
            return x * x;
        }
        public bool IsRight()
        {
            return x > 0;
        }
    }
    class Triangle : Graph
    {
        private double x, y, z;
        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double GetArea()
        {
            double p = (x + y + z) / 2;
            double sum = p * (p - x) * (p - y) * (p - z);//三角形面积公式
            return Math.Sqrt(sum);
        }
        public bool IsRight()
        {
            bool r1 = x > 0 && y > 0 && z > 0;
            bool r2 = x + y > z && x + z > y && y + z > x;//判断是否是合理的三角形
            return r1 && r2;
        }
    }
    class Factory
    {
        private Graph g;
        public Graph CreateGraph(String name, int x, int y, int z)
        {
            if (name.Equals("长方形"))
            {
                return new Rectangle(x, y);
            }
            else if (name.Equals("正方形"))
            {
                return new Square(x);
            }
            else if (name.Equals("三角形"))
            {
                return new Triangle(x, y, z);
            }
            else
            {
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double sum = 0;
            Graph g;
            Factory fa = new Factory();
            while (i != 10)
            {
                Console.WriteLine("请输入你要创建的图形(输入“三角形”、“长方形”、“正方形”)：");
                String a = Console.ReadLine();
                Console.WriteLine("请输入边长：");
                String[] aa = Console.ReadLine().Split(' ');
                int[] bb = { 0, 0, 0 };
                for (int d = 0; d < aa.Length; d++)
                {
                    bb[d] = int.Parse(aa[d]);
                }
                g = fa.CreateGraph(a, bb[0], bb[1], bb[2]);
                if (g == null)
                {
                    Console.WriteLine("暂不支持该形状类型的创建，请重试：");
                }
                if (g.IsRight()) { sum  = sum + g.GetArea(); }
                else
                {
                    Console.WriteLine("创建失败，形状不合法");
                    continue;
                }
                i++;
                Console.WriteLine("当前成功创建" + i + "个");
            }
            Console.WriteLine("您创建的图形的总面积为：" + sum);
            while (true) { }
        }
    }
}
