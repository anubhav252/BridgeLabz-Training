using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace FileProcessorMSTest
{
    [TestClass]
    public class FileProcessorTests
    {
        private FileProcessor processor;
        private string testFile;

        [TestInitialize]
        public void Setup()
        {
            processor = new FileProcessor();
            testFile = "testfile.txt";
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [TestMethod]
        public void Write_And_Read_File_Test()
        {
            processor.WriteToFile(testFile, "Hello World");
            string content = processor.ReadFromFile(testFile);

            Assert.AreEqual("Hello World", content);
        }

        [TestMethod]
        public void File_Should_Exist_After_Write()
        {
            processor.WriteToFile(testFile, "Data");
            Assert.IsTrue(File.Exists(testFile));
        }

        [TestMethod]
        public void Read_NonExisting_File_Should_Throw_Exception()
        {
            Assert.ThrowsException<IOException>(() =>
            {
                processor.ReadFromFile("nofile.txt");
            });
        }
    }
}
