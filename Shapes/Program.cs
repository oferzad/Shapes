using System;

namespace Shapes
{
    class Program
    {
        static void PrintBasedOnColor(Square s, Rectangle r, Triangle t, string color)
        {
            if (s.GetColor() == color)
                Console.WriteLine(s);

            if (r.GetColor() == color)
                Console.WriteLine(r);

            if (t.GetColor() == color)
                Console.WriteLine(t);
        }
        static void Assignment3()
        {
            Square yellowSquare = new Square(10, "Yellow");
            Rectangle yellowRectangle = new Rectangle(10, 20, "Yellow");
            Triangle blueTriangle = new Triangle(10, 5, "Blue");

            PrintBasedOnColor(yellowSquare, yellowRectangle, blueTriangle, "Yellow");
        }

        static int Poly1(Shape [] shapes, string color)
        {
            int counter = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i].GetColor() == color)
                    counter++;
            }
            return counter;
        }

        static int Poly2(Shape[] shapes, double max)
        {
            int counter = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Triangle)
                {
                    Triangle t = (Triangle)shapes[i];
                    if (t.GetLength() > max)
                        counter++;
                }
            }
            return counter;
        }

        static double Poly3(Shape[] shapes)
        {
            double sum = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Triangle)
                {
                    Triangle t = (Triangle)shapes[i];
                    sum += t.Area();
                }
                else if (shapes[i] is Rectangle)
                {
                    Rectangle r = (Rectangle)shapes[i];
                    sum += r.Area();
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Assignment3();
        }
    }
}
