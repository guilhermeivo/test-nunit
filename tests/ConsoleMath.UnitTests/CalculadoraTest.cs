using NUnit.Framework;

namespace ConsoleMath.UnitTests
{
    public class CalculadoraTest
    {
        [Test]
        public void ShouldReturnCorrectSum()
        {
            int firstValue = 10;
            int secondValue = 20;

            var result = new Calculator().SimpleMathCalculation(
                firstValue, 
                secondValue, 
                OperationEnum.addition);

            Assert.AreEqual(30, result);
        }

        [Test]
        public void ShouldReturnCorrectSubtraction()
        {
            int firstValue = 20;
            int secondValue = 10;

            var result = new Calculator().SimpleMathCalculation(
                firstValue, 
                secondValue, 
                OperationEnum.subtraction);

            Assert.AreEqual(10, result);
        }


        [Test]
        public void ShouldReturnCorrectDivision()
        {
            int firstValue = 20;
            int secondValue = 10;

            var result = new Calculator().SimpleMathCalculation(
                firstValue, 
                secondValue, 
                OperationEnum.division);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ShouldReturnCorrectMultiplication()
        {
            int firstValue = 10;
            int secondValue = 20;

            var result = new Calculator().SimpleMathCalculation(
                firstValue, 
                secondValue, 
                OperationEnum.multiplication);

            Assert.AreEqual(200, result);
        }
    }
}
