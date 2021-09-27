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

        static void PolyAssignment()
        {
            Shape[] arr = new Shape[4];
            arr[0] = new Shape(10, "blue");
            arr[1] = new Rectangle(15, 12, "red");
            arr[2] = new Triangle(14, 7, "blue");
            arr[3] = new Square(11, "red");

            int reds = Poly1(arr, "red");
            int trianglesWithLongBase = Poly2(arr, 12);
            double sumArea = Poly3(arr);

            Console.WriteLine("The Shapes:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("****************** The results *******************");
            Console.WriteLine($"Number of red shapes in the array: {reds}");
            Console.WriteLine($"Number of triangles with base longer than 12: {trianglesWithLongBase}");
            Console.WriteLine($"Sum of all shapes area: {sumArea}");
        }
        static void Main(string[] args)
        {
            PolyAssignment();
        }
    }
}
