using NUnit.Framework;
using System.Collections.Generic;

namespace ListManagerNUnitTest
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager manager;
        private List<int> list;

        [SetUp]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [Test]
        public void AddElement_Test()
        {
            manager.AddElement(list, 10);
            Assert.AreEqual(1, list.Count);
            Assert.Contains(10, list);
        }

        [Test]
        public void RemoveElement_Test()
        {
            list.Add(10);
            manager.RemoveElement(list, 10);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void GetSize_Test()
        {
            list.Add(1);
            list.Add(2);
            int size = manager.GetSize(list);
            Assert.AreEqual(2, size);
        }
    }
}
