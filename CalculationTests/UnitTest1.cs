using MTALib.Core;
using Xunit;

namespace CalculationTests
{
    public class UnitTest1
    {
        [Fact]
        public void CircleGetAreaTest()
        {
            var circle = new Circle(3.0);

            double expected = 28.274333882308138; //��������� ��������� ��� ������ � ������� ������������ �� ����� https://allcalc.ru/node/18
            //����������: ��������� ������ �� ����� ��������� �������� �� 4 ��� 5 �������� ����� �������
            double result = circle.GetArea();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TriangleGetAreaTest()
        {
            var triangle = new Triangle(2, 6, 6);

            double expected = 5.916079783099616;
            double result = triangle.GetArea();
            Assert.Equal(expected, result);
        }
    }
}