using NUnit.Framework;
using System.IO;
using System;

namespace FileProcessorNUnitTest
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor processor;
        private string testFile;

        [SetUp]
        public void Setup()
        {
            processor = new FileProcessor();
            testFile = "testfile.txt";
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [Test]
        public void Write_And_Read_File_Test()
        {
            processor.WriteToFile(testFile, "Hello World");
            string content = processor.ReadFromFile(testFile);

            Assert.AreEqual("Hello World", content);
        }

        [Test]
        public void File_Should_Exist_After_Write()
        {
            processor.WriteToFile(testFile, "Data");
            Assert.IsTrue(File.Exists(testFile));
        }

        [Test]
        public void Read_NonExisting_File_Should_Throw_Exception()
        {
            Assert.Throws<IOException>(() =>
            {
                processor.ReadFromFile("nofile.txt");
            });
        }
    }
}
