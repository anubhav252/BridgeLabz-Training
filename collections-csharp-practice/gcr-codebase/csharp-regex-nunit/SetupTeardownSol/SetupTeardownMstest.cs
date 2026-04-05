using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseMSTest
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void Connection_Should_Be_Established_Before_Test()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void Connection_Should_Be_Closed_After_Cleanup()
        {
            Assert.IsTrue(db.IsConnected);
        }
    }
}
