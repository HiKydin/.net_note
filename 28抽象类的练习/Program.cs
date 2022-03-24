using System;

namespace _28抽象类的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求输入矩形的周长和面积和输入原型的周长和面积
            Shape sp = new Circle(2);//new Square(3, 5);
            double _area = sp.GetArea();
            double _perimeter = sp.GetPerimeter();
            Console.WriteLine("这个图形的面积是{0}，周长是{1}", _area, _perimeter);
        }
        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }
        public class Square: Shape
        {
            private double _height;
            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }
            private double _weight;
            public double Weight
            {
                get { return _weight; }
                set { _weight = value; }
            }
            public Square(double height,double weight)
            {
                this.Height = height;
                this.Weight = weight;
            }
            public override double GetArea()
            {
                return Height * Weight;
            }
            public override double GetPerimeter()
            {
                return (Height + Weight) * 2;
            }
        }
        public class Circle:Shape
        {
            private double _r;
            public double R
            {
                get { return _r; }
                set { _r = value; }
            }
            public Circle(double r)
            {
                this.R = r;
            }
            public override double GetArea()
            {
                return Math.PI * this.R * this.R;
            }
            public override double GetPerimeter()
            {
                return Math.PI * 2 * this.R;
            }
        }
    }
}
