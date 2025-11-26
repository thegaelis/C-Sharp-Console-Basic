using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    // We will construct a class of Shape first

    // Class is a blueprint of attribute and operations that an object must behave. 
    // An object is the instance of the class.

    // In C# OOP, access modifier are shown as follow, sorted from closed -> open:
    // - private: The code is only accessible from the same class
    // - protected: The code is only accessible from the same class or in the class that are inherited from that class.
    // - public: The code is accessible globallly.
    // - internal: The code is accessible internally in binary code.

    // Shape class is abstract
    // So it requires some class inherited from it to make it works

    abstract class Shape
    {
        protected string Color;
        protected bool Filled;

        //Constructor: Without params
        public Shape()
        {
            this.Color  = "#000000";
            this.Filled = false;
        }
        //Constructor: With params
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        // public string getColor() {return this.Color;} -> this is a get method
        // for short, use => expression.
        public string getColor() => this.Color;

        public bool setColor(string color) 
        {
            this.Color = color; 
            return true;
        }
        public bool isFilled() => this.Filled;
        public bool setFilled(bool filled)
        {
            this.Filled = filled;
            return true;
        }

        // Abstract method
        // No implementation here.
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string toString();

    }

    //Inherits from the Shape class: Circle
    class Circle: Shape
    {
        // attributes
        private double Radius;
        // constructor
        public Circle()
        {
            this.Radius = 0;
            this.Color = "#000000";
            this.Filled = false;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;
        }
        //get-set
        public double getRadius() => this.Radius;
        public bool setRadius(double radius)
        {
            this.Radius = radius;
            return true;
        }
        public override double getArea() => Math.PI*this.Radius*this.Radius;
        public override double getPerimeter() => 2*Math.PI*this.Radius;
        public override string toString()
        {
            return $"This is the circle with radius = {getRadius()}, area = {getArea()}, perimeter = {getPerimeter()}";
        }

    }
    
    class Rectangle: Shape
    {
        // attributes
        protected double Width;
        protected double Height;
        // constructor
        public Rectangle()
        {
            this.Width = 0;
            this.Height = 0;
        }
        public Rectangle (double width, double height, string color, bool filled)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.Filled = filled;
        }
        // get-set
        public double getHeight() => this.Height;
        public bool setHeight(double height)
        {
            this.Height = height; 
            return true;
        }
        public double getWidth() => this.Width;
        public bool setWidth(double width)
        {
            this.Width = width;
            return true;
        }
        // overrided abstract function
        public override double getArea() => this.Width*this.Height;
        public override double getPerimeter() => 2*(this.Width+this.Height);
        public override string toString()
        {
            return $"This is the rectangle with width = {getWidth()}, height = {getHeight()}, area = {getArea()}, perimeter = {getPerimeter()}";
        }
    }
    class Square : Rectangle
    {
        public Square()
        {
            this.Width = this.Height = 0;
        }
        public Square(double side, string color, bool filled)
        {
            this.Width = this.Height = side;
            this.Color = color;
            this.Filled = filled;
        }
        public double getSide() => this.Width;
        public bool setSide(double side)
        {
            this.Width = this.Height = side;
            return true;
        }
        public override string toString()
        {
            return $"This is the square with width = {getWidth()}, height = {getHeight()}, area = {getArea()}, perimeter = {getPerimeter()}";
        }

    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Circle using Shape reference
            Shape circle = new Circle(5.0, "#FF0000", true);
            Console.WriteLine(circle.toString());

            // Create a Rectangle using Shape reference
            Shape rectangle = new Rectangle(4.0, 6.0, "#00FF00", false);
            Console.WriteLine(rectangle.toString());

            // Create a Square using Shape reference
            Shape square = new Square(3.0, "#0000FF", true);
            Console.WriteLine(square.toString());
        }
    }
}
