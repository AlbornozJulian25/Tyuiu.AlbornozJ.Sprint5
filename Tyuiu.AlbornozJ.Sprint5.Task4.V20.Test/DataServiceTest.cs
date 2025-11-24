using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint5.Task4.V20.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
                        
            string testPath = @"C:\DataSprint5\InPutDataFileTask4V20.txt";
                        
            Directory.CreateDirectory(Path.GetDirectoryName(testPath));
            File.WriteAllText(testPath, "1.5");
                        
            double result = ds.LoadFromDataFile(testPath);
            double expected = 11.477;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
