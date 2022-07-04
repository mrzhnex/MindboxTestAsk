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
    }
}