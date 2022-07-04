using System;

namespace MTALib.Core
{
    public class Triangle : IShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public string Name { get; set; } = "Triangle";

        public double GetArea()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public bool IsRectangular()
        {
            if (SideA > SideB && SideA > SideC)
            {
                return IsHypotenuse(SideA, SideB, SideC);
            }
            else if (SideB > SideA && SideB > SideC)
            {
                return IsHypotenuse(SideB, SideA, SideC);
            }
            else if (SideC > SideA && SideC > SideB)
            {
                return IsHypotenuse(SideC, SideA, SideB);
            }
            else
            {
                return false;
            }
        }

        private bool IsHypotenuse(double hypotenuse, double cathetA, double cathetB)
        {
            return hypotenuse * hypotenuse == cathetA * cathetA + cathetB * cathetB;
        }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }
    }
}