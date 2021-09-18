using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        protected double length;
        protected string color;

        public Shape(double length, string color)
        {
            this.color = color;
            this.length = length;
        }

        public double GetLength()
        {
            return this.length;
        }

        public void SetLength(double length)
        {
            this.length = length;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"{this.color} Shape ({this.length})";
        }
    }

    class Triangle:Shape
    {
        private double height;
        public Triangle(double length, double height, string color) :base(length, color)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public override string ToString()
        {
            return $"{this.color} Triangle ({this.length}, {this.height} )";
        }

        public double Area()
        {
            return this.length * this.height / 2;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        public Rectangle(double length, double width, string color) : base(length, color)
        {
            this.width = width;
        }

        public double GetWidth()
        {
            return this.width;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public override string ToString()
        {
            return $"{this.color} Triangle ({this.length}, {this.width} )";
        }

        public double Area()
        {
            return this.length * this.width;
        }
    }

    class Square : Rectangle 
    {
        public Square(double length, string color) : base(length, length, color)
        {
        }

        public override string ToString()
        {
            return $"{this.color} Square ({this.length})";
        }
    }
}
