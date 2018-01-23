//класи-абстракція (приклад)
using System;

namespace ConsoleApplication
{
    abstract class Figure
    {
        float x;//координата X
        float y;//координата Y

        public Figure(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract float Perimeter();
        public abstract float Area();

    }

    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float x, float y, float width, float height)
            : base(x, y)
        {
            this.Width = width;
            this.Height = height;
        }

        public override float Perimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override float Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //x, y - not used
            Rectangle rect = new Rectangle(10.0f, 10.0f, 20.0f, 30.0f);
            float perimetr = rect.Perimeter();
            float area = rect.Area();
            Console.WriteLine("Perimetr - {0} Area - {1}", perimetr, area);

            Console.ReadKey();
        }
    }
}
