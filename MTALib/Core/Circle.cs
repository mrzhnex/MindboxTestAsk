using System;

namespace MTALib.Core
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }
        public string Name { get; set; } = "Circle";

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}