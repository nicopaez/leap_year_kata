﻿namespace LeapYearKata
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

        [Test]
        public void IsLeapWhenIsDivisibleBy4AndNotBy100()
        {
            Assert.IsTrue(new Year(1996).IsLeap());

        }
    }
}
