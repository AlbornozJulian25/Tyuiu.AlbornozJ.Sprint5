using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AlbornozJ.Sprint5.Task5.V2.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
                        
            string testPath = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
                        
            Directory.CreateDirectory(Path.GetDirectoryName(testPath));
                        
            File.WriteAllText(testPath, "5.5\n-3.2\n8.1\n-1.0\n2.7\n-4.3");
                        
            double result = ds.LoadFromDataFile(testPath);
                        
            double expected = 5.433;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
