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
        static void Main(string[] args)
        {
            Assignment3();
        }
    }
}
