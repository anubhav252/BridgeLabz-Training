using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListManagerMSTest
{
    [TestClass]
    public class ListManagerTests
    {
        private ListManager manager;
        private List<int> list;

        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void AddElement_Test()
        {
            manager.AddElement(list, 10);
            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list.Contains(10));
        }

        [TestMethod]
        public void RemoveElement_Test()
        {
            list.Add(10);
            manager.RemoveElement(list, 10);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void GetSize_Test()
        {
            list.Add(1);
            list.Add(2);
            int size = manager.GetSize(list);
            Assert.AreEqual(2, size);
        }
    }
}
