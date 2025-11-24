using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint5.Task6.V14.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
                        
            string testPath = @"C:\DataSprint5\InPutDataFileTask6V14.txt";
                        
            Directory.CreateDirectory(Path.GetDirectoryName(testPath));
                        
            File.WriteAllText(testPath, "Hello, world! How are you? I'm fine; thank you. This is a test: (example) [another] {one} - \"quoted\".");

            int result = ds.LoadFromDataFile(testPath);
            int expected = 17;

            Assert.AreEqual(expected, result);
        }
    }
}
