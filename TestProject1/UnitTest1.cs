using review5;

namespace TestProject1
{
    
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_Test1()
        {
            int x = 10; 
            int y = 20;
            int expected = x+ y;

            int actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sub_Test1()
        {
            int x = 10;
            int y = 20;
            int expected = x - y;

            int actual = calculator.Sub(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Mul_Test1()
        {
            int x = 10;
            int y = 20;
            int expected = x * y;

            int actual = calculator.Mul(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Div_Test1()
        {
            int x = 10;
            int y = 20;
            int expected = x / y;

            int actual = calculator.Div(x, y);
            Assert.AreEqual(expected, actual);
        }

    }
}