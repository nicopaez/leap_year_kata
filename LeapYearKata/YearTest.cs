namespace LeapYearKata
{
    using NUnit.Framework;

    [TestFixture]
    public class YearTest
    {
        [Test]
        public void IsNotLeapWhenIsNotDivisableBy4()
        {
            Assert.IsFalse(new Year(2001).IsLeap());
        }
    }
}
