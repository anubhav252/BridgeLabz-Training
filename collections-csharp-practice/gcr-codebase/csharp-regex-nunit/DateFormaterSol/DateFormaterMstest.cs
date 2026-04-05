using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateFormatterMSTest
{
    [TestClass]
    public class DateFormatterTests
    {
        private DateFormatter formatter;

        [TestInitialize]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [TestMethod]
        public void FormatDate_ValidDate_Should_Return_Formatted_Date()
        {
            string result = formatter.FormatDate("2024-08-15");
            Assert.AreEqual("15-08-2024", result);
        }

        [TestMethod]
        public void FormatDate_InvalidDate_Should_Throw_Exception()
        {
            Assert.ThrowsException<FormatException>(() =>
            {
                formatter.FormatDate("15-08-2024");
            });
        }

        [TestMethod]
        public void FormatDate_Invalid_String_Should_Throw_Exception()
        {
            Assert.ThrowsException<FormatException>(() =>
            {
                formatter.FormatDate("invalid-date");
            });
        }
    }
}
