using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using WeatherDataMunging;

namespace WeatherDataMungingTests
{
    [TestClass]
    public class ProcessDataTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentException()
        {
            string filePath = string.Empty;
            DataWrangler.ProcessData(filePath);
        }
        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void TestDirectoryNotFoundException()
        {
            string filePath = @"c:\users\source\repos\code-katas\weatherdatamunging\weather.dat";
            DataWrangler.ProcessData(filePath);
        }
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestFileNotFoundException()
        {
            string filePath = @"c:\users\derek\source\repos\code-katas\weatherdatamunging\weatherTest.dat";
            DataWrangler.ProcessData(filePath);
        }
    }
}
