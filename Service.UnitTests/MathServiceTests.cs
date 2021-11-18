namespace Service.UnitTests
{
    using Service.Services;
    using NUnit.Framework;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum()
        {
            var x = 4;
            var y = 15;

            var math = new MathService();
            var result = math.Sum(x, y);
            Assert.AreEqual(19, result);
        }

        [Test]
        public void Multiply()
        {
            var x = 2;
            var y = 14;

            var math = new MathService();
            var result = math.Multiply(x, y);
            Assert.AreEqual(28, result);
        }
    }
}