using NUnit.Framework;
using System;

namespace DateFormatterNUnitTest
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ValidDate_Should_Return_Formatted_Date()
        {
            string result = formatter.FormatDate("2024-08-15");
            Assert.AreEqual("15-08-2024", result);
        }

        [Test]
        public void FormatDate_InvalidDate_Should_Throw_Exception()
        {
            Assert.Throws<FormatException>(() =>
            {
                formatter.FormatDate("15-08-2024");
            });
        }

        [Test]
        public void FormatDate_Invalid_String_Should_Throw_Exception()
        {
            Assert.Throws<FormatException>(() =>
            {
                formatter.FormatDate("invalid-date");
            });
        }
    }
}
