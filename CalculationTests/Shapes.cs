using MTALib.Core;
using Xunit;

namespace CalculationTests
{
    public class Shapes
    {
        [Fact]
        public void CircleGetAreaTest()
        {
            var circle = new Circle(3.0);

            double expected = 28.274333882308138; //ожидаемый результат был найден с помощью калькулятора на сайте https://allcalc.ru/node/18
            //примечание: несколько сайтов до этого округляли значение до 4 или 5 символов после запятой
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

        [Fact]
        public void TriangleIsRectangular()
        {
            var triangle = new Triangle(5, 4, 3);
            bool expected = true;
            bool result = triangle.IsRectangular();
            Assert.Equal(expected, result);
        }

        //пишу unit тесты впервые, неуверен насчет того, нужен ли набор данных "входные данные -> ожидаемое значение
    }
}