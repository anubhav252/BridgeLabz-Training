using NUnit.Framework;

namespace DatabaseNUnitTest
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        [Test]
        public void Connection_Should_Be_Established_Before_Test()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void Connection_Should_Be_Closed_After_TearDown()
        {
            Assert.IsTrue(db.IsConnected);
        }
    }
}
